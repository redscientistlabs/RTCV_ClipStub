namespace RTCV_ClipPlayer
{
    partial class StubForm
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
            this.pnTarget = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.Button();
            this.bAddClip = new System.Windows.Forms.Button();
            this.videoView = new LibVLCSharp.WinForms.VideoView();
            this.pnTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTarget
            // 
            this.pnTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnTarget.Controls.Add(this.btnPause);
            this.pnTarget.Controls.Add(this.bAddClip);
            this.pnTarget.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTarget.Location = new System.Drawing.Point(0, 0);
            this.pnTarget.Name = "pnTarget";
            this.pnTarget.Size = new System.Drawing.Size(800, 31);
            this.pnTarget.TabIndex = 176;
            this.pnTarget.Tag = "color:dark3";
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(679, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(118, 23);
            this.btnPause.TabIndex = 181;
            this.btnPause.TabStop = false;
            this.btnPause.Tag = "color:dark2";
            this.btnPause.Text = "Play / Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // bAddClip
            // 
            this.bAddClip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bAddClip.FlatAppearance.BorderSize = 0;
            this.bAddClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddClip.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bAddClip.ForeColor = System.Drawing.Color.White;
            this.bAddClip.Location = new System.Drawing.Point(4, 3);
            this.bAddClip.Name = "bAddClip";
            this.bAddClip.Size = new System.Drawing.Size(92, 23);
            this.bAddClip.TabIndex = 180;
            this.bAddClip.TabStop = false;
            this.bAddClip.Tag = "color:dark2";
            this.bAddClip.Text = "Open Video";
            this.bAddClip.UseVisualStyleBackColor = false;
            this.bAddClip.Click += new System.EventHandler(this.bAddClip_Click);
            // 
            // videoView
            // 
            this.videoView.BackColor = System.Drawing.Color.Black;
            this.videoView.Location = new System.Drawing.Point(160, 111);
            this.videoView.MediaPlayer = null;
            this.videoView.Name = "videoView";
            this.videoView.Size = new System.Drawing.Size(461, 240);
            this.videoView.TabIndex = 177;
            this.videoView.Text = "videoView";
            // 
            // StubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoView);
            this.Controls.Add(this.pnTarget);
            this.DoubleBuffered = true;
            this.Name = "StubForm";
            this.Text = "ClipPlayer";
            this.Load += new System.EventHandler(this.StubForm_Load);
            this.pnTarget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTarget;
        private System.Windows.Forms.Button bAddClip;
        private System.Windows.Forms.Button btnPause;
        public LibVLCSharp.WinForms.VideoView videoView;
    }
}

