namespace Music_Player
{
    partial class Form1
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
            playButton = new Button();
            stopButton = new Button();
            progressBar1 = new ProgressBar();
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            fileToolopenFilefile = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            nowPlaying = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Location = new Point(320, 360);
            playButton.Name = "playButton";
            playButton.Size = new Size(143, 50);
            playButton.TabIndex = 0;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += button1_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(502, 365);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(42, 41);
            stopButton.TabIndex = 1;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(320, 331);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(143, 23);
            progressBar1.TabIndex = 2;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(37, 20);
            fileMenu.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolopenFilefile });
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(180, 22);
            openFileToolStripMenuItem.Text = "Open File";
            // 
            // fileToolopenFilefile
            // 
            fileToolopenFilefile.Name = "fileToolopenFilefile";
            fileToolopenFilefile.Size = new Size(92, 22);
            fileToolopenFilefile.Text = "File";
            fileToolopenFilefile.Click += fileToolStripMenuItem1_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // nowPlaying
            // 
            nowPlaying.AutoSize = true;
            nowPlaying.Location = new Point(367, 302);
            nowPlaying.Name = "nowPlaying";
            nowPlaying.Size = new Size(46, 15);
            nowPlaying.TabIndex = 4;
            nowPlaying.Text = "Playing";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nowPlaying);
            Controls.Add(progressBar1);
            Controls.Add(stopButton);
            Controls.Add(playButton);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Form1";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playButton;
        private Button stopButton;
        private ProgressBar progressBar1;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem fileToolopenFilefile;
        private OpenFileDialog openFileDialog;
        private Label nowPlaying;
    }
}
