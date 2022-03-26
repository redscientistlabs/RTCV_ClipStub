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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoView
            // 
            this.videoView.BackColor = System.Drawing.Color.Black;
            this.videoView.Location = new System.Drawing.Point(0, -1);
            this.videoView.MaximumSize = new System.Drawing.Size(1280, 720);
            this.videoView.MediaPlayer = null;
            this.videoView.MinimumSize = new System.Drawing.Size(1280, 720);
            this.videoView.Name = "videoView";
            this.videoView.Size = new System.Drawing.Size(1280, 720);
            this.videoView.TabIndex = 0;
            this.videoView.Text = "videoView1";
            this.videoView.Click += new System.EventHandler(this.videoView_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.bPause);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 725);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1280, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Controls";
            // 
            // bPause
            // 
            this.bPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bPause.FlatAppearance.BorderSize = 0;
            this.bPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPause.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bPause.Location = new System.Drawing.Point(6, 18);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(96, 64);
            this.bPause.TabIndex = 181;
            this.bPause.TabStop = false;
            this.bPause.Tag = "color:dark2";
            this.bPause.Text = "Play/Pause";
            this.bPause.UseVisualStyleBackColor = false;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1280, 813);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.videoView);
            this.MaximumSize = new System.Drawing.Size(1288, 840);
            this.MinimumSize = new System.Drawing.Size(1288, 840);
            this.Name = "VideoPlayer";
            this.Text = "Video Player";
            this.Activated += new System.EventHandler(this.VideoPlayer_OnEnter);
            this.Deactivate += new System.EventHandler(this.VideoPlayer_OnLeave);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoPlayer_OnClose);
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            this.Shown += new System.EventHandler(this.VideoPlayer_Load);
            this.Enter += new System.EventHandler(this.VideoPlayer_OnEnter);
            this.Leave += new System.EventHandler(this.VideoPlayer_OnLeave);
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bPause;
    }
}