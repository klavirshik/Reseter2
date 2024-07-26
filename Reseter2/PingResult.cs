using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class PingResult
    {
        public long Ping { get; set; }
        public int TimeoutPing { get; set; }
        public IPAddress Ip;
        public bool TimedOut;
        public PingResult(long ping, int timeoutPing, IPAddress ip, bool timedOut)
        {
            Ping = ping;
            TimeoutPing = timeoutPing;
            Ip = ip;
            TimedOut = timedOut;
        }
    }
}
