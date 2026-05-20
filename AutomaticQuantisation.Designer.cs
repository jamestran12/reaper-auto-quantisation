using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace reaper_auto_quantisation
{
    partial class AutomaticQuantisation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomaticQuantisation));
            btnImport = new System.Windows.Forms.Button();
            cBoxDAW = new System.Windows.Forms.ComboBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuImport = new ToolStripMenuItem();
            mnuAudio = new ToolStripMenuItem();
            mnuDAW = new ToolStripMenuItem();
            mnuExport = new ToolStripMenuItem();
            mnuExportAs = new ToolStripMenuItem();
            mnuQuit = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            mnuUndo = new ToolStripMenuItem();
            mnuRedo = new ToolStripMenuItem();
            mnuPref = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnImport
            // 
            btnImport.Cursor = Cursors.Hand;
            btnImport.Font = new Font("Segoe UI", 25F);
            btnImport.Location = new Point(40, 270);
            btnImport.Margin = new Padding(20);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(700, 100);
            btnImport.TabIndex = 10;
            btnImport.Text = "Import file";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // cBoxDAW
            // 
            cBoxDAW.Cursor = Cursors.Hand;
            cBoxDAW.Font = new Font("Segoe UI", 20F);
            cBoxDAW.FormattingEnabled = true;
            cBoxDAW.Items.AddRange(new object[] { "Ableton Live", "Audacity", "REAPER" });
            cBoxDAW.Location = new Point(40, 400);
            cBoxDAW.Margin = new Padding(0);
            cBoxDAW.Name = "cBoxDAW";
            cBoxDAW.Size = new Size(700, 53);
            cBoxDAW.TabIndex = 10;
            cBoxDAW.Text = "Select DAW:";
            cBoxDAW.SelectedIndexChanged += cBoxDAW_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(0, 40);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 70, 10, 70);
            label1.Size = new Size(777, 207);
            label1.TabIndex = 10;
            label1.Text = "Audio Quantisation Automator";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuEdit, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuImport, mnuExport, mnuExportAs, mnuQuit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // mnuImport
            // 
            mnuImport.DropDownItems.AddRange(new ToolStripItem[] { mnuAudio, mnuDAW });
            mnuImport.Name = "mnuImport";
            mnuImport.Size = new Size(245, 26);
            mnuImport.Text = "Import";
            // 
            // mnuAudio
            // 
            mnuAudio.Enabled = false;
            mnuAudio.Name = "mnuAudio";
            mnuAudio.ShortcutKeys = Keys.Control | Keys.I;
            mnuAudio.Size = new Size(288, 26);
            mnuAudio.Text = "Audio file";
            mnuAudio.Click += mnuAudio_Click;
            // 
            // mnuDAW
            // 
            mnuDAW.Name = "mnuDAW";
            mnuDAW.ShortcutKeys = Keys.Control | Keys.Shift | Keys.I;
            mnuDAW.Size = new Size(288, 26);
            mnuDAW.Text = "DAW project file";
            mnuDAW.Click += mnuDAW_Click;
            // 
            // mnuExport
            // 
            mnuExport.Enabled = false;
            mnuExport.Name = "mnuExport";
            mnuExport.ShortcutKeys = Keys.Control | Keys.E;
            mnuExport.Size = new Size(245, 26);
            mnuExport.Text = "Export";
            mnuExport.Click += mnuExport_Click;
            // 
            // mnuExportAs
            // 
            mnuExportAs.Enabled = false;
            mnuExportAs.Name = "mnuExportAs";
            mnuExportAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.E;
            mnuExportAs.Size = new Size(245, 26);
            mnuExportAs.Text = "Export As";
            mnuExportAs.Click += mnuExportAs_Click;
            // 
            // mnuQuit
            // 
            mnuQuit.Name = "mnuQuit";
            mnuQuit.ShortcutKeys = Keys.Control | Keys.Q;
            mnuQuit.Size = new Size(245, 26);
            mnuQuit.Text = "Quit";
            mnuQuit.Click += mnuQuit_Click;
            // 
            // mnuEdit
            // 
            mnuEdit.DropDownItems.AddRange(new ToolStripItem[] { mnuUndo, mnuRedo, mnuPref });
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(49, 24);
            mnuEdit.Text = "Edit";
            // 
            // mnuUndo
            // 
            mnuUndo.Name = "mnuUndo";
            mnuUndo.ShortcutKeys = Keys.Control | Keys.Z;
            mnuUndo.Size = new Size(258, 26);
            mnuUndo.Text = "Undo";
            mnuUndo.Click += mnuUndo_Click;
            // 
            // mnuRedo
            // 
            mnuRedo.Name = "mnuRedo";
            mnuRedo.ShortcutKeys = Keys.Control | Keys.Y;
            mnuRedo.Size = new Size(258, 26);
            mnuRedo.Text = "Redo";
            mnuRedo.Click += mnuRedo_Click;
            // 
            // mnuPref
            // 
            mnuPref.Enabled = false;
            mnuPref.Name = "mnuPref";
            mnuPref.ShortcutKeys = Keys.Control | Keys.Shift | Keys.P;
            mnuPref.Size = new Size(258, 26);
            mnuPref.Text = "Preferences";
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(55, 24);
            mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(133, 26);
            mnuAbout.Text = "About";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(2, 501);
            label2.Name = "label2";
            label2.Padding = new Padding(300, 10, 300, 10);
            label2.Size = new Size(777, 48);
            label2.TabIndex = 10;
            label2.Text = "James Tran © 2026";
            // 
            // AutomaticQuantisation
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cBoxDAW);
            Controls.Add(btnImport);
            Controls.Add(menuStrip1);
            Cursor = Cursors.IBeam;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "AutomaticQuantisation";
            Text = "Audio Quantisation Automator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ComboBox cBoxDAW;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuImport;
        private ToolStripMenuItem mnuExport;
        private ToolStripMenuItem mnuUndo;
        private ToolStripMenuItem mnuRedo;
        private ToolStripMenuItem mnuAbout;
        private ToolStripMenuItem mnuAudio;
        private ToolStripMenuItem mnuDAW;
        private ToolStripMenuItem mnuExportAs;
        private ToolStripMenuItem mnuQuit;
        private Label label2;
        private ToolStripMenuItem mnuPref;
    }
}
