using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.SCCMsearch
{
    internal class SCCMmain
    {
        
        private System.Security.Principal.WindowsIdentity sid = WindowsIdentity.GetCurrent();
        public string ssid;
        public SCCMmain()
        {
          ssid = sid.User.AccountDomainSid.Value;
        }
        
    }
}
