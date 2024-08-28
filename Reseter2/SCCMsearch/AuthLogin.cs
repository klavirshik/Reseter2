using Reseter2.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.SCCMsearch
{
    internal class AuthLogin : IAuthType
    {
        public AuthLogin()
        {

        }
        public string Name
        {
            get
            {
                return SGlobalSetting.settingSCCM.username;
            }
        }
        public string Password
        {
            get
            {
                return SGlobalSetting.settingSCCM.password;
            }
        }
        public string AuthString()
        {
            return "user=" + Name + ";password=" + Password + ";";
        }
    }
}
