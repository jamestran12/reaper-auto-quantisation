using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace reaper_auto_quantisation
{
    public partial class Menu : UserControl
    {
        private static Menu? instance;
        public static OpenFileDialog? dialog;
        public static readonly string[] DAWtypes = { ".abl", ".aup3", ".rpp" };
        public static readonly string[] audioTypes = { ".mp3", ".ogg", ".flac", ".m4a" };
        public Menu()
        {
            InitializeComponent();
            instance = this;
            instance.AllowDrop = true;
            instance.DragEnter += new DragEventHandler(Menu_DragEnter);
            instance.DragDrop += new DragEventHandler(Menu_DragDrop);
        }

        void Menu_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Menu_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 1) return;
        }
        public void importProjectFile(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            switch (cBoxDAW.SelectedIndex)
            {
                case 0:
                    // dialog.Filter = "Ableton Note Set (*.abl)|*.abl";
                    break;
                case 1:
                    // dialog.Filter = "Audacity Project File (*.aup3)|*.aup3";
                    break;
                case 2:
                    dialog.Filter = "REAPER Project File (*.rpp)|*.rpp";
                    break;
                default:
                    dialog.Filter = "REAPER Project File (*.rpp)|*.rpp";
                    break;
            }

            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            FileInfo info = new FileInfo(dialog.SafeFileName);
            string fileName = info.ToString();
            validate(fileName);
        }

        private void cBoxDAW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxDAW.SelectedIndex != 2)
            {
                cBoxDAW.SelectedIndex = 2;
            }
        }
        public void validate(string fileName)
        {
            var check = false;
            foreach (string type in DAWtypes)
            {
                if (Path.GetExtension(fileName) == type)
                {
                    check = true;
                }
            }
            if (cBoxDAW.SelectedIndex < 0)
            {
                foreach (string type in audioTypes)
                {
                    if (Path.GetExtension(fileName) == type)
                    {
                        check = true;
                    }
                }
            }
            if (check != true)
            {
                // Do something
                return;
            }
            Process p = new Process();
            p.Dock = DockStyle.Fill;
            AutomaticQuantisation.Instance.Controls.Add(p);
            p.BringToFront();
        }
        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quitting may result in a loss of progress. Are you sure you want to quit?", "Exit Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void mnuAudio_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Audio files (*.3gp;*.acc";
        }
    }
}
