using BeatDetectorCSharp;
using NAudio.MediaFoundation;
using NAudio.Wave;
using NAudio.Wave.Compression;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;

namespace reaper_auto_quantisation
{
    public partial class Process : UserControl
    {
        public static AudioFileReader? audio;
        public static string? FileName;
        public OpenFileDialog? dialog = Menu.dialog;
        public string[] audioTypes = Menu.audioTypes;
        public string[] DAWtypes = Menu.DAWtypes;
        public static string? trunFileName;
        public static string? temp_file;
        public static string? mediaFolder;

        private WaveOutEvent? output;
        private int beat;
        int[]? beats;
        public Process()
        {
            InitializeComponent();
            processProject();
            parseFile.Text = $"Currently reading \n{trunFileName}.";
            offset.Text = "00:00:000";
        }

        private void processProject()
        {
            string path = dialog.FileName;
            string ext = Path.GetExtension(path);
            string line;
            if (FileName != null)
            {
                initBeatDetector();
                Quantise(ext);
            }
            switch (ext)
            {
                case ".abl":
                    // no functionality
                    break;
                case ".aup3":
                    // no functionality
                    break;
                case ".rpp":
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string[] lines = File.ReadAllLines(path);
                        for (int x = 0; x < lines.Length - 1; x++)
                        {
                            if (lines[x].Contains("<SOURCE"))
                            {
                                line = File.ReadLines(path).Skip(x + 1).Take(1).First();
                                string[] split = line.Split('"');
                                FileName = Path.GetDirectoryName(path) + "\\" + split[1];
                                string[] seg = split[1].Split("\\");
                                trunFileName = seg[1];
                                return;
                            }
                        }
                    }
                    break;
                default:
                    FileName = dialog.FileName;
                    string[] segments = FileName.Split("\\");
                    trunFileName = segments[segments.Length - 1];
                    break;
            }
        }

        private void Quantise(string ext)
        {
            switch (ext)
            {
                case ".abl":
                    temp_file = Path.GetTempPath() + "\\temp.abl";
                    break;
                case ".aup3":
                    temp_file = Path.GetTempPath() + "\\temp.aup3";
                    break;
                case ".rpp":
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "REAPER Project File (*.rpp)|*.rpp";
                    save.FileName = Path.GetFileNameWithoutExtension(dialog.FileName) + "_quantised.rpp";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        temp_file = save.FileName;
                        mediaFolder = Path.GetDirectoryName(save.FileName) + "\\Media";
                        if (File.Exists(temp_file) == false) File.Copy(dialog.FileName, temp_file);
                        if (Directory.Exists(mediaFolder) == false) Directory.CreateDirectory(mediaFolder);
                        if (File.Exists(mediaFolder + "\\" + trunFileName) == false) File.Copy(FileName, mediaFolder + "\\" + trunFileName);

                        List<int> beatDistance = new List<int>();

                        for (int i = 0; i < beats.Length - 1; i++)
                        {
                            beatDistance.Add(beats[i + 1] - beats[i]);
                        }

                        var bpm = 60000 / beatDistance[0];

                        if (bpm > 500)
                        {
                            bpm /= 2;
                        }

                        int expectedDistance = (60000 / bpm) + 10;
                        int newPosition = 0;
                        int newLength = 0;
                        int playRate = 0;
                        int linePos = 0;
                        decimal multiplier = 0;
                        string[] tempArray = [];

                        for (int i = 0; i < beats.Length; i++)
                        {
                            using (StreamReader sr = File.OpenText(temp_file))
                            {
                                string[] lines = File.ReadAllLines(dialog.FileName);
                                for (int x = linePos; x < lines.Length; x++)
                                {
                                    if (lines[x].Contains("<ITEM"))
                                    {
                                        linePos = x;
                                        List<string> template = NewLineConstructor();
                                        tempArray = template.ToArray();
                                        int offset = beats[0];

                                        if (i != 0)
                                        {
                                            multiplier = beatDistance[i - 1] / (expectedDistance - 10);
                                            multiplier = (int)System.Math.Floor(multiplier * 4) / 4;
                                            newLength = (int)(expectedDistance * multiplier);
                                            playRate = newLength / beats[i];

                                            if (i != 1)
                                            {
                                                newPosition = (int)(offset + expectedDistance * multiplier);
                                                tempArray[1] = "POSITION" + newPosition;
                                            }

                                            tempArray[3] = "LENGTH" + newLength;
                                            tempArray[16] = "PLAYRATE" + playRate;
                                        }
                                    }
                                }
                            }

                            using (var sw = new System.IO.StreamWriter(temp_file, true, Encoding.UTF8))
                            {
                                for (int j = 0; j < tempArray.Length; j++)
                                {
                                    // Source - https://stackoverflow.com/a/14057684
                                    // Posted by anothershrubery, modified by community. See post 'Timeline' for change history
                                    // Retrieved 2026-06-12, License - CC BY-SA 3.0

                                    byte[] bytes = Encoding.Default.GetBytes(tempArray[j]);
                                    string newLine = Encoding.UTF8.GetString(bytes);

                                    if (j == tempArray.Length - 1)
                                    {
                                        sw.WriteLine(newLine, j + linePos + 1);
                                    }
                                    else
                                    {
                                        sw.WriteLine("IGUID {19CD1F9B-3580-41B2-B1BF-715BD7988E1E}", j + linePos - 1);
                                    }
                                }
                            }
                            linePos += tempArray.Length;
                        }
                    }
                    break;
                default:
                    // no support
                    break;
            }
        }

        private List<string> NewLineConstructor()
        {
            List<string> newLines = new List<string>();
            using (StreamReader sr = File.OpenText(temp_file))
            {
                string[] lines = File.ReadAllLines(dialog.FileName);
                for (int x = 0; x < lines.Length; x++)
                {
                    if (lines[x].Contains("<ITEM"))
                    {
                        for (int line = x; line <= x + 20; line++)
                        {
                            newLines.Add(lines[line]);
                        }
                        break;
                    }
                }
            }
            newLines.Add(">");
            newLines.Add(">");
            return newLines;
        }
        private void initBeatDetector()
        {
            BeatDetector detector = BeatDetector.Instance();
            System.Timers.Timer timer = new System.Timers.Timer();
            audio = new AudioFileReader(FileName);

            timer.Interval = 50;
            timer.AutoReset = true;
            timer.Enabled = true;

            detector.loadSystem();
            detector.LoadSong(1024, FileName);
            progressTimer.Start();
            detector.setStarted(true);
            int i = 0;
            List<int> tempBeats = new List<int>();

            while (detector.areWePlaying) {
                detector.update();
                if (beat != detector.getLastBeat())
                {
                    beat = detector.getLastBeat();
                    tempBeats.Add(beat);
                    // Debug.WriteLine(beat);
                    // Debug.WriteLine(beats[i]);
                    i++;
                }
                Thread.Sleep(100);
            }
            beats = tempBeats.ToArray();
        }
        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.pb_value < progressBar1.pb_Max)
            {
                progressBar1.pb_value++;
                int current_length = progressBar1.pb_value / 100 * audio.TotalTime.Milliseconds;
                int second = (current_length / 1000) % 60;
                int minute = current_length / 60;
                int millisecond = current_length % 1000;

                offset.Text = $"{minute}:{second}:{millisecond}";
                progressBar1.Refresh();
            }
            if (progressBar1.pb_value == progressBar1.pb_Max)
            {
                progressTimer.Stop();
            }
        }

        private void btnQuantise_click(object sender, EventArgs e)
        {
            processProject();
        }
    }
}
