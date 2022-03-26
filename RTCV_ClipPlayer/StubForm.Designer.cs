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
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.pnTarget = new System.Windows.Forms.Panel();
            this.bAddClip = new System.Windows.Forms.Button();
            this.bOpenVLC = new System.Windows.Forms.Button();
            this.pnTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(118, 450);
            this.pnSideBar.TabIndex = 175;
            this.pnSideBar.Tag = "color:dark3";
            // 
            // pnTarget
            // 
            this.pnTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTarget.Controls.Add(this.bAddClip);
            this.pnTarget.Controls.Add(this.bOpenVLC);
            this.pnTarget.Location = new System.Drawing.Point(124, 27);
            this.pnTarget.Name = "pnTarget";
            this.pnTarget.Size = new System.Drawing.Size(660, 136);
            this.pnTarget.TabIndex = 176;
            this.pnTarget.Tag = "color:dark1";
            // 
            // bAddClip
            // 
            this.bAddClip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddClip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bAddClip.FlatAppearance.BorderSize = 0;
            this.bAddClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddClip.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bAddClip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bAddClip.Location = new System.Drawing.Point(554, 32);
            this.bAddClip.Name = "bAddClip";
            this.bAddClip.Size = new System.Drawing.Size(103, 23);
            this.bAddClip.TabIndex = 180;
            this.bAddClip.TabStop = false;
            this.bAddClip.Tag = "color:dark2";
            this.bAddClip.Text = "Add Clip";
            this.bAddClip.UseVisualStyleBackColor = false;
            this.bAddClip.Click += new System.EventHandler(this.bAddClip_Click);
            // 
            // bOpenVLC
            // 
            this.bOpenVLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOpenVLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bOpenVLC.FlatAppearance.BorderSize = 0;
            this.bOpenVLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpenVLC.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bOpenVLC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bOpenVLC.Location = new System.Drawing.Point(554, 3);
            this.bOpenVLC.Name = "bOpenVLC";
            this.bOpenVLC.Size = new System.Drawing.Size(103, 23);
            this.bOpenVLC.TabIndex = 179;
            this.bOpenVLC.TabStop = false;
            this.bOpenVLC.Tag = "color:dark2";
            this.bOpenVLC.Text = "Video Player";
            this.bOpenVLC.UseVisualStyleBackColor = false;
            this.bOpenVLC.Click += new System.EventHandler(this.OnOpenVLC);
            // 
            // StubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnTarget);
            this.Controls.Add(this.pnSideBar);
            this.Name = "StubForm";
            this.Text = "Clipussi";
            this.Load += new System.EventHandler(this.StubForm_Load);
            this.pnTarget.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSideBar;
        private System.Windows.Forms.Panel pnTarget;
        private System.Windows.Forms.Button bAddClip;
        private System.Windows.Forms.Button bOpenVLC;
    }
}

