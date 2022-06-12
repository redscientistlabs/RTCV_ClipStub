using RTCV.CorruptCore;
using RTCV.NetCore;
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

namespace ClipStub
{
    public partial class VideoPlayer : Form
    {

        public static Stream ClipStream;
        public static string ClipPath;
        public static LibVLCSharp.Shared.StreamMediaInput StreamInput;
        public static LibVLCSharp.Shared.Media LoadedMedia;

        public VideoPlayer()
        {
            InitializeComponent();
            videoView.MediaPlayer = new LibVLCSharp.Shared.MediaPlayer(StubForm.LibVLCInstance);
        }

        // Constants for decoding the Win32 message.
        protected const int WM_PARENTNOTIFY = 0x210;
        protected const int WM_LBUTTONDOWN = 0x201;
        protected const int WM_RBUTTONDOWN = 0x204;

        protected override void WndProc(ref Message m)
        {
            // This is the message from child controls to their parent when a Win32 event occurs.
            if (m.Msg == WM_PARENTNOTIFY)
            {
                int wparam = m.WParam.ToInt32();

                if (wparam == WM_LBUTTONDOWN)
                {
                    // TODO: Do something with the mouse event.
                    if(!pnOptions.Visible)
                        videoView.MediaPlayer.SetPause(videoView.MediaPlayer.IsPlaying);

                    return;
                }
                if (wparam == WM_RBUTTONDOWN)
                {
                    // TODO: Do something with the mouse event.
                    pnOptions.Visible = !pnOptions.Visible;

                    return;
                }
            }

            base.WndProc(ref m);
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
                pnOptions.Visible = false;
            }
        }

        public void PlayVLC()
        {
            if (LoadedMedia != null)
            {
                videoView.MediaPlayer.Media = LoadedMedia;
                videoView.MediaPlayer.Play();
                videoView.MediaPlayer.EnableMouseInput = true;
            }

        }

        private void btnVideoToStockpile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "video files|*.mp4;*.webm;*.mkv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ClipPath = ofd.FileName;
                VanguardCore.OpenRomFilename = ClipPath;

                LocalNetCoreRouter.QueryRoute<BlastLayer>(RTCV.NetCore.Endpoints.UI, RTCV.NetCore.Commands.Remote.TriggerHotkey, "Blast+RawStash", true);
                LocalNetCoreRouter.QueryRoute<BlastLayer>(RTCV.NetCore.Endpoints.UI, RTCV.NetCore.Commands.Remote.TriggerHotkey, "Stash->Stockpile", true);
            }
        }

        private void label1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var item in files)
            {
                ClipPath = item;
                VanguardCore.OpenRomFilename = ClipPath;
                LocalNetCoreRouter.QueryRoute<BlastLayer>(RTCV.NetCore.Endpoints.UI, RTCV.NetCore.Commands.Remote.TriggerHotkey, "Blast+RawStash", true);
                LocalNetCoreRouter.QueryRoute<BlastLayer>(RTCV.NetCore.Endpoints.UI, RTCV.NetCore.Commands.Remote.TriggerHotkey, "Stash->Stockpile", true);

            }

        }

        private void lbDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
