using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.NetworkInformation;
using System.Net;

namespace Reseter2
{
    internal class Pinger               
    {
        private string NameOrAddress;
        private int TimeoutCount;
        private IPAddress Ip;
       
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
            bool succes = false;
            long ping = 0;
            Ping pinger = null;
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(this.NameOrAddress);
                pingable = reply.Status == IPStatus.TimedOut;
                succes = reply.Status == IPStatus.Success;
                ping = reply.RoundtripTime;
                Ip = reply.Address;
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
           return new PingResult(ping, TimeoutCount, Ip, pingable, succes); 
        }

    }
}
