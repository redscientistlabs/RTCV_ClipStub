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
            this.pnOptions = new System.Windows.Forms.Panel();
            this.lbDrop = new System.Windows.Forms.Label();
            this.btnVideoToStockpile = new System.Windows.Forms.Button();
            this.btnLoadVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            this.pnOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoView
            // 
            this.videoView.BackColor = System.Drawing.Color.Black;
            this.videoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView.Location = new System.Drawing.Point(0, 0);
            this.videoView.MediaPlayer = null;
            this.videoView.Name = "videoView";
            this.videoView.Size = new System.Drawing.Size(784, 461);
            this.videoView.TabIndex = 0;
            this.videoView.Text = "videoView1";
            this.videoView.Click += new System.EventHandler(this.videoView_Click);
            // 
            // pnOptions
            // 
            this.pnOptions.AllowDrop = true;
            this.pnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnOptions.Controls.Add(this.lbDrop);
            this.pnOptions.Controls.Add(this.btnVideoToStockpile);
            this.pnOptions.Controls.Add(this.btnLoadVideo);
            this.pnOptions.Location = new System.Drawing.Point(17, 17);
            this.pnOptions.Name = "pnOptions";
            this.pnOptions.Size = new System.Drawing.Size(205, 212);
            this.pnOptions.TabIndex = 182;
            this.pnOptions.Tag = "color:dark3";
            this.pnOptions.Visible = false;
            this.pnOptions.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
            // 
            // lbDrop
            // 
            this.lbDrop.AllowDrop = true;
            this.lbDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lbDrop.ForeColor = System.Drawing.Color.White;
            this.lbDrop.Location = new System.Drawing.Point(45, 88);
            this.lbDrop.Name = "lbDrop";
            this.lbDrop.Size = new System.Drawing.Size(115, 110);
            this.lbDrop.TabIndex = 183;
            this.lbDrop.Text = "Drag and drop to batch import to stockpile";
            this.lbDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
            this.lbDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbDrop_DragEnter);
            this.lbDrop.DragOver += new System.Windows.Forms.DragEventHandler(this.label1_DragOver);
            // 
            // btnVideoToStockpile
            // 
            this.btnVideoToStockpile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnVideoToStockpile.FlatAppearance.BorderSize = 0;
            this.btnVideoToStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoToStockpile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVideoToStockpile.ForeColor = System.Drawing.Color.White;
            this.btnVideoToStockpile.Location = new System.Drawing.Point(9, 49);
            this.btnVideoToStockpile.Name = "btnVideoToStockpile";
            this.btnVideoToStockpile.Size = new System.Drawing.Size(185, 27);
            this.btnVideoToStockpile.TabIndex = 183;
            this.btnVideoToStockpile.TabStop = false;
            this.btnVideoToStockpile.Tag = "color:dark2";
            this.btnVideoToStockpile.Text = "Load Video to Stockpile";
            this.btnVideoToStockpile.UseVisualStyleBackColor = false;
            this.btnVideoToStockpile.Click += new System.EventHandler(this.btnVideoToStockpile_Click);
            // 
            // btnLoadVideo
            // 
            this.btnLoadVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLoadVideo.FlatAppearance.BorderSize = 0;
            this.btnLoadVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadVideo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoadVideo.ForeColor = System.Drawing.Color.White;
            this.btnLoadVideo.Location = new System.Drawing.Point(9, 11);
            this.btnLoadVideo.Name = "btnLoadVideo";
            this.btnLoadVideo.Size = new System.Drawing.Size(185, 27);
            this.btnLoadVideo.TabIndex = 182;
            this.btnLoadVideo.TabStop = false;
            this.btnLoadVideo.Tag = "color:dark2";
            this.btnLoadVideo.Text = "Load Video to Player";
            this.btnLoadVideo.UseVisualStyleBackColor = false;
            this.btnLoadVideo.Click += new System.EventHandler(this.button1_Click);
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnOptions);
            this.Controls.Add(this.videoView);
            this.Name = "VideoPlayer";
            this.Text = "ClipStub";
            this.Activated += new System.EventHandler(this.VideoPlayer_OnEnter);
            this.Deactivate += new System.EventHandler(this.VideoPlayer_OnLeave);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoPlayer_OnClose);
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            this.Shown += new System.EventHandler(this.VideoPlayer_Load);
            this.Enter += new System.EventHandler(this.VideoPlayer_OnEnter);
            this.Leave += new System.EventHandler(this.VideoPlayer_OnLeave);
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            this.pnOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView;
        private System.Windows.Forms.Panel pnOptions;
        private System.Windows.Forms.Button btnLoadVideo;
        private System.Windows.Forms.Label lbDrop;
        private System.Windows.Forms.Button btnVideoToStockpile;
    }
}