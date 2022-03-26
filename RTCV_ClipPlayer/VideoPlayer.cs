using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTCV_ClipPlayer
{
    public partial class VideoPlayer : Form
    {
        public VideoPlayer()
        {
            InitializeComponent();
            videoView.MediaPlayer = new LibVLCSharp.Shared.MediaPlayer(StubForm.LibVLCInstance);
        }

        private void VideoPlayer_Load(object sender, EventArgs e)
        {
        }

        private void VideoPlayer_OnLeave(object sender, EventArgs e)
        {
            //videoView.MediaPlayer.Stop();
        }

        private void VideoPlayer_OnEnter(object sender, EventArgs e)
        {
        }

        private void VideoPlayer_OnClose(object sender, FormClosingEventArgs e)
        {
            videoView.MediaPlayer?.Dispose();
        }

        public LibVLCSharp.WinForms.VideoView GetVideoView()
        {
            return videoView;
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            videoView.MediaPlayer.SetPause(videoView.MediaPlayer.IsPlaying);
        }

        private void videoView_Click(object sender, EventArgs e)
        {
            videoView.MediaPlayer.SetPause(videoView.MediaPlayer.IsPlaying);
        }
    }
}
