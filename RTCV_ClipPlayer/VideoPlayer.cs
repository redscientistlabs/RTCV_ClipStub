using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTCV_ClipPlayer
{
    public partial class VideoPlayer : Form
    {

        public static Stream ClipStream;
        public static string ClipPath;
        public static LibVLCSharp.Shared.StreamMediaInput StreamInput;
        public static LibVLCSharp.Shared.LibVLC LibVLCInstance;
        public static LibVLCSharp.Shared.Media LoadedMedia;

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

            Environment.Exit(0);
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "video files|*.mp4;*.webm;*.mkv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ClipPath = ofd.FileName;

                ClipStream = ofd.OpenFile();
                StreamInput = new LibVLCSharp.Shared.StreamMediaInput(ClipStream);
                LoadedMedia = new LibVLCSharp.Shared.Media(StubForm.LibVLCInstance, StreamInput);
                VanguardCore.OpenRomFilename = ClipPath;

                PlayVLC();
            }
        }

        public void PlayVLC()
        {
            if (LoadedMedia != null)
            {
                videoView.MediaPlayer.Media = LoadedMedia;
                videoView.MediaPlayer.Play();
            }

        }
    }
}
