using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.Setting
{
    public partial class SettingSCCMControl : UserControl
    {
        public SettingSCCMControl()
        {
            InitializeComponent();
            UpdateSetting();
        }

        public void UpdateSetting()
        {
            if (SGlobalSetting.settingSCCM != null)
            {
                ib_server.Text = SGlobalSetting.settingSCCM.server;
                ib_dataBase.Text = SGlobalSetting.settingSCCM.dataBase;
                ib_username.Text = SGlobalSetting.settingSCCM.username;
                ib_password.Text = SGlobalSetting.settingSCCM.password;
                cb_on.Checked = SGlobalSetting.settingSCCM.on;

                cb_windowsAuth.Checked = SGlobalSetting.settingSCCM.windowsAuth;
                SearchControl(cb_on.Checked);
            }
        }
        private void AuthControl(bool enable)
        {
            ib_username.Enabled = enable;
            ib_password.Enabled = enable;
        }
        private void SearchControl(bool enable)
        {
            ib_server.Enabled = enable;
            ib_dataBase.Enabled = enable;
            cb_windowsAuth.Enabled = enable;
            bt_checkConnect.Enabled = enable;
            AuthControl(!cb_windowsAuth.Checked && enable);
        }

        private void cb_on_CheckedChanged(object sender, EventArgs e)
        {
            SearchControl(cb_on.Checked);
        }

        private void cb_windowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            AuthControl(!cb_windowsAuth.Checked);
        }

        public bool edited()
        {
            return (SGlobalSetting.settingSCCM.server != ib_server.Text ||
            SGlobalSetting.settingSCCM.dataBase != ib_dataBase.Text ||
            SGlobalSetting.settingSCCM.username != ib_username.Text ||
            SGlobalSetting.settingSCCM.password != ib_password.Text ||
            SGlobalSetting.settingSCCM.on != cb_on.Checked ||
            SGlobalSetting.settingSCCM.windowsAuth != cb_windowsAuth.Checked);

        }

        public void Save()
        {
            SGlobalSetting.settingSCCM.server = ib_server.Text;
            SGlobalSetting.settingSCCM.dataBase = ib_dataBase.Text;
            SGlobalSetting.settingSCCM.username = ib_username.Text;
            SGlobalSetting.settingSCCM.password = ib_password.Text;
            SGlobalSetting.settingSCCM.on = cb_on.Checked;
            SGlobalSetting.settingSCCM.windowsAuth = cb_windowsAuth.Checked;

        }
    }
}
