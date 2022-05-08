using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class DummyMemoryDomain : IMemoryDomain
    {
        public string Name => "DUMMY";

        public long Size => 1;

        public int WordSize => 1;

        public bool BigEndian => false;

        public byte PeekByte(long addr)
        {
            return 0;
        }

        public byte[] PeekBytes(long address, int length)
        {
            return new byte[length];
        }

        public void PokeByte(long addr, byte val)
        {
            
        }

        public void PokeBytes(long addr, byte[] val)
        {
            
        }
    }
}
