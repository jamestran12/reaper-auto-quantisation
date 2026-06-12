using NAudio.Dmo;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace reaper_auto_quantisation
{
    public partial class ProgressBar : UserControl
    {
        public ProgressBar()
        {
            InitializeComponent();
            this.Size = new Size(500, 30);
            this.BackColor = Color.Transparent;
            DoubleBuffered = true;
        }

        public Color bara = System.Drawing.ColorTranslator.FromHtml("#222222");
        public int pb_value = 0, pb_Max = 100, pb_Min = 0;
        float percent = 0f;
        private void ProgressBar_Paint(object sender, PaintEventArgs e)
        {
            if (Process.FileName == null) return;
            AudioFileReader audio = new AudioFileReader(Process.FileName);
            int totalTime = (int)audio.TotalTime.TotalMilliseconds / 1000;
            Color colour = Color.FromArgb(10, bara);
            SolidBrush brush = new SolidBrush(bara);

            e.Graphics.FillRectangle(brush, new RectangleF(0, 35, ClientSize.Width, 2));
            percent = (float)ClientSize.Width / pb_Max;
            e.Graphics.FillRectangle(brush, new RectangleF(pb_value * percent / totalTime, 0, 6, ClientSize.Height));

            Pen pen = new Pen(Color.Transparent, 0);
            e.Graphics.DrawRectangle(pen, 0, 0, ClientSize.Width, ClientSize.Height);
        }
    }
}
