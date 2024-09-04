using Reseter2.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.SCCMsearch
{
    internal class AuthLogin : IAuthType
    {
        private string User = null;
        private string Pass = null;
        public AuthLogin()
        {

        }

        public AuthLogin(string user, string pass)
        {
            User = user;
            Pass = pass;
        }
        public string Name
        {
            get
            {
                if(User != null) return User;
                return SGlobalSetting.settingSCCM.username;
            }
        }
        public string Password
        {
            get
            {
                if(Pass != null) return Pass;
                return SGlobalSetting.settingSCCM.password;
            }
        }
        public string AuthString()
        {
            return "user=" + Name + ";password=" + Password + ";";
        }
    }
}
