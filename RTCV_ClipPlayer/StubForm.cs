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
    using System;
    using System.Drawing;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;
    using System.IO;
    using System.Windows.Forms;
    using RTCV.Common;
    using RTCV.NetCore;
    using RTCV.UI;
    using RTCV.Vanguard;
    using RTCV.CorruptCore;
    using System.Reflection;
    using LibVLCSharp.Shared;

    public delegate void Open_VLC();
    public partial class StubForm : Form
    {
        public static Stream ClipStream;
        public static string ClipPath;
        public static StubForm form;
        public static LibVLCSharp.Shared.LibVLC libVLC;
        public static LibVLCSharp.Shared.MediaPlayer mp;

        public StubForm()
        {
            InitializeComponent();

            LibVLCSharp.Shared.Core.Initialize();
            libVLC = new LibVLCSharp.Shared.LibVLC();
            mp = new LibVLCSharp.Shared.MediaPlayer(libVLC);
            videoView.MediaPlayer = mp;

            SyncObjectSingleton.SyncObject = this;
            form = this;


        }


        private void StubForm_Load(object sender, EventArgs e)
        {
            Colors.SetRTCColor(Color.FromArgb(42, 77, 42), this);

            Focus();
            VanguardCore.Start();
            S.SET(this);
            RTCV.Common.Logging.StartLogging(VanguardCore.logPath);


        }

        public static void PlayOnVLC(string filename)
        {
            var m = new Media(libVLC, filename);
            form.videoView.MediaPlayer.Play(m);

            VanguardCore.OpenRomFilename = ClipPath;
        }


        public void Pause()
        {

        }

        public void Stop()
        {

        }

        private void bAddClip_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "video files|*.mp4;*.webm;*.mkv;*.webm;*.avi;*.mpg;*.m4v;*.mkv;*.mp2";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ClipPath = ofd.FileName;
                PlayOnVLC(ClipPath);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause();
        }

    }
}
