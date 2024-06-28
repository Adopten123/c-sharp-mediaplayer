namespace mediaplayer
{
    partial class mediaplayer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mediaplayer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.PictureBox();
            this.add_button = new System.Windows.Forms.PictureBox();
            this.playlistbutton = new System.Windows.Forms.PictureBox();
            this.videoBox = new System.Windows.Forms.ListBox();
            this.end_track = new System.Windows.Forms.Label();
            this.start_track = new System.Windows.Forms.Label();
            this.openbutton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.play = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Controls.Add(this.playlistbutton);
            this.panel2.Controls.Add(this.videoBox);
            this.panel2.Controls.Add(this.end_track);
            this.panel2.Controls.Add(this.start_track);
            this.panel2.Controls.Add(this.openbutton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.trackBar);
            this.panel2.Controls.Add(this.play);
            this.panel2.Controls.Add(this.pause);
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 168);
            this.panel2.TabIndex = 2;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete.Image = global::mediaplayer.Properties.Resources.minus;
            this.delete.Location = new System.Drawing.Point(711, 102);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(34, 34);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 10;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_button.Image = global::mediaplayer.Properties.Resources.newplus1;
            this.add_button.Location = new System.Drawing.Point(711, 62);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(34, 34);
            this.add_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_button.TabIndex = 9;
            this.add_button.TabStop = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // playlistbutton
            // 
            this.playlistbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playlistbutton.Image = global::mediaplayer.Properties.Resources.playlist;
            this.playlistbutton.Location = new System.Drawing.Point(711, 22);
            this.playlistbutton.Name = "playlistbutton";
            this.playlistbutton.Size = new System.Drawing.Size(34, 34);
            this.playlistbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playlistbutton.TabIndex = 8;
            this.playlistbutton.TabStop = false;
            this.playlistbutton.Click += new System.EventHandler(this.playlistbutton_Click);
            // 
            // videoBox
            // 
            this.videoBox.FormattingEnabled = true;
            this.videoBox.Location = new System.Drawing.Point(212, 22);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(489, 134);
            this.videoBox.TabIndex = 7;
            this.videoBox.SelectedIndexChanged += new System.EventHandler(this.videoBox_SelectedIndexChanged);
            // 
            // end_track
            // 
            this.end_track.AutoSize = true;
            this.end_track.BackColor = System.Drawing.SystemColors.Control;
            this.end_track.Location = new System.Drawing.Point(748, 3);
            this.end_track.Name = "end_track";
            this.end_track.Size = new System.Drawing.Size(49, 13);
            this.end_track.TabIndex = 5;
            this.end_track.Text = "00:00:00";
            // 
            // start_track
            // 
            this.start_track.AutoSize = true;
            this.start_track.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.start_track.Location = new System.Drawing.Point(5, 3);
            this.start_track.Name = "start_track";
            this.start_track.Size = new System.Drawing.Size(49, 13);
            this.start_track.TabIndex = 4;
            this.start_track.Text = "00:00:00";
            // 
            // openbutton
            // 
            this.openbutton.Image = global::mediaplayer.Properties.Resources.folder;
            this.openbutton.Location = new System.Drawing.Point(754, 22);
            this.openbutton.Name = "openbutton";
            this.openbutton.Size = new System.Drawing.Size(34, 34);
            this.openbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openbutton.TabIndex = 4;
            this.openbutton.TabStop = false;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mediaplayer.Properties.Resources.volume;
            this.pictureBox1.Location = new System.Drawing.Point(83, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Black;
            this.trackBar.Location = new System.Drawing.Point(102, 22);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(104, 45);
            this.trackBar.TabIndex = 2;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // play
            // 
            this.play.Image = global::mediaplayer.Properties.Resources.play;
            this.play.Location = new System.Drawing.Point(43, 22);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(34, 34);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.play.TabIndex = 1;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.Image = global::mediaplayer.Properties.Resources.pause;
            this.pause.Location = new System.Drawing.Point(3, 22);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(34, 34);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pause.TabIndex = 0;
            this.pause.TabStop = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Black;
            this.progressBar.Location = new System.Drawing.Point(60, 0);
            this.progressBar.Maximum = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(685, 45);
            this.progressBar.TabIndex = 6;
            this.progressBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.progressBar.Scroll += new System.EventHandler(this.progressBar_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(800, 510);
            this.axWindowsMediaPlayer.TabIndex = 0;
            this.axWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer_PlayStateChange);
            // 
            // mediaplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Name = "mediaplayer";
            this.Text = "mediaplayer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox playlistbutton;
        private System.Windows.Forms.ListBox videoBox;
        private System.Windows.Forms.Label end_track;
        private System.Windows.Forms.Label start_track;
        private System.Windows.Forms.PictureBox openbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.TrackBar progressBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox add_button;
        private System.Windows.Forms.PictureBox delete;
    }
}

