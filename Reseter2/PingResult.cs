using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class PingResult
    {
        public long Ping { get; set; }
        public int TimeoutPing { get; set; }
        public PingResult(long ping, int timeoutPing)
        {
            Ping = ping;
            TimeoutPing = timeoutPing; 
        }
    }
}
