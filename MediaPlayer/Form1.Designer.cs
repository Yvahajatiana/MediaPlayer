namespace MediaPlayer
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
            playPauseBtn = new Button();
            previousBtn = new Button();
            stopBtn = new Button();
            nextBtn = new Button();
            openBtn = new Button();
            timelineProgBar = new ProgressBar();
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            timeLbl = new Label();
            playlistLbox = new ListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            SuspendLayout();
            // 
            // playPauseBtn
            // 
            playPauseBtn.Location = new Point(38, 374);
            playPauseBtn.Name = "playPauseBtn";
            playPauseBtn.Size = new Size(102, 29);
            playPauseBtn.TabIndex = 0;
            playPauseBtn.Text = "Play / Pause";
            playPauseBtn.UseVisualStyleBackColor = true;
            playPauseBtn.Click += playPauseBtn_Click;
            // 
            // previousBtn
            // 
            previousBtn.Location = new Point(182, 374);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(94, 29);
            previousBtn.TabIndex = 1;
            previousBtn.Text = "Previous";
            previousBtn.UseVisualStyleBackColor = true;
            previousBtn.Click += previousBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Location = new Point(324, 374);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(94, 29);
            stopBtn.TabIndex = 2;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(462, 374);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(94, 29);
            nextBtn.TabIndex = 3;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // openBtn
            // 
            openBtn.Location = new Point(615, 374);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(94, 29);
            openBtn.TabIndex = 4;
            openBtn.Text = "Open";
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += openBtn_Click;
            // 
            // timelineProgBar
            // 
            timelineProgBar.Location = new Point(40, 339);
            timelineProgBar.Name = "timelineProgBar";
            timelineProgBar.Size = new Size(548, 29);
            timelineProgBar.TabIndex = 5;
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Location = new Point(40, 12);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(669, 313);
            videoView1.TabIndex = 6;
            videoView1.Text = "videoView1";
            // 
            // timeLbl
            // 
            timeLbl.AutoSize = true;
            timeLbl.Location = new Point(594, 339);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(42, 20);
            timeLbl.TabIndex = 7;
            timeLbl.Text = "Time";
            // 
            // playlistLbox
            // 
            playlistLbox.FormattingEnabled = true;
            playlistLbox.ItemHeight = 20;
            playlistLbox.Location = new Point(714, 36);
            playlistLbox.Name = "playlistLbox";
            playlistLbox.Size = new Size(406, 284);
            playlistLbox.TabIndex = 8;
            playlistLbox.SelectedIndexChanged += playlistLbox_SelectedIndexChanged;
            playlistLbox.SelectedValueChanged += playlistLbox_SelectedValueChanged;
            playlistLbox.DoubleClick += playlistLbox_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(714, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 9;
            label1.Text = "Videos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 433);
            Controls.Add(label1);
            Controls.Add(playlistLbox);
            Controls.Add(timeLbl);
            Controls.Add(videoView1);
            Controls.Add(timelineProgBar);
            Controls.Add(openBtn);
            Controls.Add(nextBtn);
            Controls.Add(stopBtn);
            Controls.Add(previousBtn);
            Controls.Add(playPauseBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playPauseBtn;
        private Button previousBtn;
        private Button stopBtn;
        private Button nextBtn;
        private Button openBtn;
        private ProgressBar timelineProgBar;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private Label timeLbl;
        private ListBox playlistLbox;
        private Label label1;
    }
}