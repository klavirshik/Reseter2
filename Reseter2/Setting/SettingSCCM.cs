using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.Setting
{
    [Serializable]
    internal class SettingSCCM
    {
        public string server;
        public string dataBase;
        public string username;
        public string password;
        public bool on;
        public bool windowsAuth;
        
        public SettingSCCM()
        {
            server = string.Empty;
            dataBase = string.Empty;
            username = string.Empty;
            password = string.Empty;
            on = false;
            windowsAuth = false;
        }

    }
}
