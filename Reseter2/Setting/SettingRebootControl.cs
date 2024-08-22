using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.Setting
{
    public partial class SettingRebootControl : UserControl
    {
        public SettingRebootControl()
        {
            InitializeComponent();
            UpdateSetting();
           
        }
        public void UpdateSetting()
        {
            if (SGlobalSetting.settingReboot != null)
            {
                nb_checkConnect.Value = SGlobalSetting.settingReboot.checkConnect;
                nb_timeOutReboot.Value = SGlobalSetting.settingReboot.timeOutReboot;
                nb_timeCheckBeforReboot.Value = SGlobalSetting.settingReboot.timeCheckBeforReboot;
                nb_sizeHistoryItem.Value = SGlobalSetting.settingReboot.sizeHistoryItem;
            }
        }

        public void Save()
        {
            SGlobalSetting.settingReboot.checkConnect = (int)nb_checkConnect.Value;
            SGlobalSetting.settingReboot.timeOutReboot = (int)nb_timeOutReboot.Value;
            SGlobalSetting.settingReboot.timeCheckBeforReboot = (int)nb_timeCheckBeforReboot.Value;
            SGlobalSetting.settingReboot.sizeHistoryItem = (int)nb_sizeHistoryItem.Value;

        }

      
    }
}
