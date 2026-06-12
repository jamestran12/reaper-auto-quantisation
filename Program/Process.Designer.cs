namespace reaper_auto_quantisation
{
    partial class Process
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            parseFile = new Label();
            btnQuantise = new Button();
            progressTimer = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            offset = new TextBox();
            label2 = new Label();
            label3 = new Label();
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
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // parseFile
            // 
            parseFile.Anchor = AnchorStyles.None;
            parseFile.Font = new Font("Segoe UI", 15F);
            parseFile.Location = new Point(50, 50);
            parseFile.Name = "parseFile";
            parseFile.Size = new Size(700, 200);
            parseFile.TabIndex = 0;
            parseFile.Text = "Currently reading {FileName}.";
            parseFile.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnQuantise
            // 
            btnQuantise.Cursor = Cursors.Hand;
            btnQuantise.Font = new Font("Segoe UI", 25F);
            btnQuantise.Location = new Point(245, 384);
            btnQuantise.Name = "btnQuantise";
            btnQuantise.Size = new Size(300, 100);
            btnQuantise.TabIndex = 6;
            btnQuantise.Text = "Quantise";
            btnQuantise.UseVisualStyleBackColor = true;
            btnQuantise.Click += btnQuantise_click;
            // 
            // progressTimer
            // 
            progressTimer.Interval = 1;
            progressTimer.Tick += progressTimer_Tick;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Transparent;
            progressBar1.Location = new Point(38, 265);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(700, 70);
            progressBar1.TabIndex = 7;
            // 
            // offset
            // 
            offset.Cursor = Cursors.IBeam;
            offset.Location = new Point(38, 220);
            offset.Name = "offset";
            offset.Size = new Size(125, 27);
            offset.TabIndex = 8;
            offset.Text = "0:00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(38, 189);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 9;
            label2.Text = "Offset";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(2, 501);
            label3.Name = "label3";
            label3.Padding = new Padding(300, 10, 300, 10);
            label3.Size = new Size(777, 48);
            label3.TabIndex = 11;
            label3.Text = "James Tran © 2026";
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
            mnuImport.Enabled = false;
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
            // 
            // mnuDAW
            // 
            mnuDAW.Enabled = false;
            mnuDAW.Name = "mnuDAW";
            mnuDAW.ShortcutKeys = Keys.Control | Keys.Shift | Keys.I;
            mnuDAW.Size = new Size(288, 26);
            mnuDAW.Text = "DAW project file";
            // 
            // mnuExport
            // 
            mnuExport.Name = "mnuExport";
            mnuExport.ShortcutKeys = Keys.Control | Keys.E;
            mnuExport.Size = new Size(245, 26);
            mnuExport.Text = "Export";
            // 
            // mnuExportAs
            // 
            mnuExportAs.Name = "mnuExportAs";
            mnuExportAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.E;
            mnuExportAs.Size = new Size(245, 26);
            mnuExportAs.Text = "Export As";
            // 
            // mnuQuit
            // 
            mnuQuit.Name = "mnuQuit";
            mnuQuit.ShortcutKeys = Keys.Control | Keys.Q;
            mnuQuit.Size = new Size(245, 26);
            mnuQuit.Text = "Quit";
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
            // 
            // mnuRedo
            // 
            mnuRedo.Name = "mnuRedo";
            mnuRedo.ShortcutKeys = Keys.Control | Keys.Y;
            mnuRedo.Size = new Size(258, 26);
            mnuRedo.Text = "Redo";
            // 
            // mnuPref
            // 
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuEdit, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // Process
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(offset);
            Controls.Add(progressBar1);
            Controls.Add(btnQuantise);
            Controls.Add(parseFile);
            Controls.Add(menuStrip1);
            Name = "Process";
            Size = new Size(800, 600);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label parseFile;
        private Button btnQuantise;
        private System.Windows.Forms.Timer progressTimer;
        private ProgressBar progressBar1;
        private TextBox offset;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuImport;
        private ToolStripMenuItem mnuAudio;
        private ToolStripMenuItem mnuDAW;
        private ToolStripMenuItem mnuExport;
        private ToolStripMenuItem mnuExportAs;
        private ToolStripMenuItem mnuQuit;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuUndo;
        private ToolStripMenuItem mnuRedo;
        private ToolStripMenuItem mnuPref;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuAbout;
        private MenuStrip menuStrip1;
    }
}
