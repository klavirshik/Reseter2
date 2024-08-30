using Reseter2.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace Reseter2.SCCMsearch
{
    internal class SQLconnector
    {
        private MySql.Data.MySqlClient.MySqlConnection Connection;
        private IAuthType AuthType;
        public SQLconnector()
        {
            if (SGlobalSetting.settingSCCM.windowsAuth)
            {
                AuthType = new AuthWin();
            }
            else
            {
                AuthType = new AuthLogin();
            }
            string stringConnect = "server=" + SGlobalSetting.settingSCCM.server + ";database=" + SGlobalSetting.settingSCCM.dataBase + ";" + AuthType.AuthString();
            try
            {
                Connection = new MySql.Data.MySqlClient.MySqlConnection(stringConnect);
                Connection.Open();
            }
            catch
            {
                Console.WriteLine("Повторное бы подключение");
            }
            
        }
    }
}
