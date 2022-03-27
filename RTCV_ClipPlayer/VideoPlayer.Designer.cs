namespace RTCV_ClipPlayer
{
    partial class VideoPlayer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoView = new LibVLCSharp.WinForms.VideoView();
            this.bPause = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoView
            // 
            this.videoView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoView.BackColor = System.Drawing.Color.Black;
            this.videoView.Location = new System.Drawing.Point(0, 39);
            this.videoView.MediaPlayer = null;
            this.videoView.Name = "videoView";
            this.videoView.Size = new System.Drawing.Size(784, 423);
            this.videoView.TabIndex = 0;
            this.videoView.Text = "videoView1";
            this.videoView.Click += new System.EventHandler(this.videoView_Click);
            // 
            // bPause
            // 
            this.bPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bPause.FlatAppearance.BorderSize = 0;
            this.bPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPause.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bPause.ForeColor = System.Drawing.Color.White;
            this.bPause.Location = new System.Drawing.Point(663, 6);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(116, 27);
            this.bPause.TabIndex = 181;
            this.bPause.TabStop = false;
            this.bPause.Tag = "color:dark2";
            this.bPause.Text = "Play/Pause";
            this.bPause.UseVisualStyleBackColor = false;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.btnLoadVideo);
            this.panel1.Controls.Add(this.bPause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 39);
            this.panel1.TabIndex = 182;
            this.panel1.Tag = "color:dark3";
            // 
            // btnLoadVideo
            // 
            this.btnLoadVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLoadVideo.FlatAppearance.BorderSize = 0;
            this.btnLoadVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadVideo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoadVideo.ForeColor = System.Drawing.Color.White;
            this.btnLoadVideo.Location = new System.Drawing.Point(5, 6);
            this.btnLoadVideo.Name = "btnLoadVideo";
            this.btnLoadVideo.Size = new System.Drawing.Size(116, 27);
            this.btnLoadVideo.TabIndex = 182;
            this.btnLoadVideo.TabStop = false;
            this.btnLoadVideo.Tag = "color:dark2";
            this.btnLoadVideo.Text = "Load Video";
            this.btnLoadVideo.UseVisualStyleBackColor = false;
            this.btnLoadVideo.Click += new System.EventHandler(this.button1_Click);
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.videoView);
            this.Name = "VideoPlayer";
            this.Text = "ClipPlayer";
            this.Activated += new System.EventHandler(this.VideoPlayer_OnEnter);
            this.Deactivate += new System.EventHandler(this.VideoPlayer_OnLeave);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoPlayer_OnClose);
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            this.Shown += new System.EventHandler(this.VideoPlayer_Load);
            this.Enter += new System.EventHandler(this.VideoPlayer_OnEnter);
            this.Leave += new System.EventHandler(this.VideoPlayer_OnLeave);
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadVideo;
    }
}