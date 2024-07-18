using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.NetworkInformation;

namespace Reseter2
{
    internal class Pinger               
    {
        private string NameOrAddress;
        private int TimeoutCount;
       
        public Pinger(string nameOrAddress)
        {
            this.NameOrAddress = nameOrAddress;
        }
        public int Timeout() {
            return TimeoutCount;       
        }
        public PingResult PingHost()
        {
            bool pingable = false;
            long ping = 0;
            Ping pinger = null;
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(this.NameOrAddress);
                pingable = reply.Status == IPStatus.TimedOut;
                ping = reply.RoundtripTime;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }
            if (pingable) TimeoutCount++;
            return new PingResult(ping, TimeoutCount);
        }

    }
}
