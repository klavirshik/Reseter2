using Reseter2.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.SCCMsearch
{
    internal class AuthWin : IAuthType
    {
        private static System.Security.Principal.WindowsIdentity user = WindowsIdentity.GetCurrent();
        public static string uid;
        public AuthWin()
        { 
            uid = user.User.AccountDomainSid.Value;
        }        
        public string Name
        {
            get
            {
                return "";
            }
        }
        public string Password
        {
            get
            {
                return uid;
            }
        }
        public string AuthString()
        {
            Console.WriteLine(Password);
            return "Integrated Security=true;";
        }
    }
}
