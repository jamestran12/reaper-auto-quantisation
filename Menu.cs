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
        public static OpenFileDialog dialog = null;
        public Menu()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Menu_DragEnter);
            this.DragDrop += new DragEventHandler(Menu_DragDrop);
        }

        void Menu_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Menu_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 1) return;
            Console.Write(files);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            MenuStrip menu = this.Controls["menuStrip1"] as MenuStrip;
            ToolStripMenuItem mnuExport = menu.Items["mnuExport"] as ToolStripMenuItem;
            ToolStripMenuItem mnuExportAs = menu.Items["mnuExportAs"] as ToolStripMenuItem;
            importProjectFile(cBoxDAW, mnuExport, mnuExportAs);
        }

        public void importProjectFile(ComboBox cBoxDAW, ToolStripMenuItem mnuExport, ToolStripMenuItem mnuExportAs)
        {
            dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            switch (cBoxDAW.SelectedIndex)
            {
                case 0:
                    dialog.Filter = "Ableton Note Set (*.abl)|*.abl";
                    break;
                case 1:
                    dialog.Filter = "Audacity Project File (*.aup3)|*.aup3";
                    break;
                case 2:
                    dialog.Filter = "REAPER Project File (*.rpp)|*.rpp";
                    break;
                default:
                    dialog.Filter = "All Files (*.*)|*.*";
                    break;
            }

            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            FileInfo info = new FileInfo(dialog.SafeFileName);
            string fileName = info.ToString();
            AutomaticQuantisation auto = new AutomaticQuantisation();
            validate(mnuExport, mnuExportAs, cBoxDAW, fileName);
        }

        private void cBoxDAW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxDAW.SelectedIndex != 2)
            {
                return;
            }
            var error = new ErrorProvider();
            error.SetIconAlignment(cBoxDAW, ErrorIconAlignment.MiddleRight);
            error.SetIconPadding(cBoxDAW, 2);
            error.BlinkRate = 1000;
            error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
        }
        public void validate(ToolStripMenuItem mnuExport, ToolStripMenuItem mnuExportAs, ComboBox cBoxDAW, string fileName)
        {
            string[] DAWtypes = { "abl", "aup3", "rpp" };
            string[] audioTypes = { "mp3", "ogg", "flac", "m4a" };
            if (cBoxDAW.SelectedIndex > 2)
            {
                foreach (string type in DAWtypes)
                {
                    if (Path.GetExtension(fileName) == type)
                    {
                        mnuExport.Enabled = true;
                        mnuExportAs.Enabled = true;
                    }
                }
            }
            mnuExport.Enabled = true;
            mnuExportAs.Enabled = true;
        }
        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quitting may result in a loss of progress. Are you sure you want to quit?", "Exit Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void mnuDAW_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.importProjectFile(cBoxDAW, mnuExport, mnuExportAs);
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {

        }

        private void mnuExportAs_Click(object sender, EventArgs e)
        {

        }

        private void mnuAudio_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Audio files (*.3gp;*.acc";
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {

        }

        private void mnuRedo_Click(object sender, EventArgs e)
        {

        }
    }
}
