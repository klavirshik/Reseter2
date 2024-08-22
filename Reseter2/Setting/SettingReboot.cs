using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.Setting
{
    [Serializable]
    internal class SettingReboot
    {
        public int checkConnect;
        public int timeOutReboot;
        public int timeCheckBeforReboot;
        public int sizeHistoryItem;
        public SettingReboot()
        {
            this.checkConnect = 5;
            this.timeOutReboot = 5;
            this.timeCheckBeforReboot = 50;
            this.sizeHistoryItem = 200;
        }
    }
}
