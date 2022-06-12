using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipStub
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

    public delegate void Open_VLC();
    public partial class StubForm : Form
    {
        public static LibVLCSharp.Shared.LibVLC LibVLCInstance;
        public static VideoPlayer Player;
        public StubForm()
        {
            InitializeComponent();

            SyncObjectSingleton.SyncObject = this;
        }

        private void StubForm_Load(object sender, EventArgs e)
        {
            Colors.SetRTCColor(Color.FromArgb(149, 120, 161), this);

            Focus();
            VanguardCore.Start();
            S.SET(this);
            RTCV.Common.Logging.StartLogging(VanguardCore.logPath);
            LibVLCInstance = new LibVLCSharp.Shared.LibVLC("--input-repeat=65535");
            Player = new VideoPlayer();
            Player.Show();
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Hide();
        }

    }
}
