using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;
using Reseter2.SCCMsearch;
using Reseter2.Setting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Reseter2.Seacher.SeahcLocal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Reseter2.Seacher
{
    internal class SeachSCCM : ISeaherMetod
    {
        private MySql.Data.MySqlClient.MySqlConnection Connection;
        private IAuthType AuthType;
        private List<IComp> comps = new List<IComp>();
        private ResultUpdate Update;
        private bool enable;
        private string error;
        private Mode mode;

        private enum Mode{
            PCname,
            Login,
            Username
        }

        public SeachSCCM()
        {
            if (SGlobalSetting.settingSCCM.windowsAuth)
            {
                AuthType = new AuthWin();
            }
            else
            {
                AuthType = new AuthLogin();
            }
           
        }

        public SeachSCCM(bool AuthMetod, string User = "", string Pass = "")
        {
            if (AuthMetod)
            {
                AuthType = new AuthWin();
            }
            else
            {
                AuthType = new AuthLogin(User, Pass);
            }

        }
        public void Change(ResultUpdate sender, string seach)
        {
            Activate();
            Update = sender;
            if (Connection.State == ConnectionState.Open)
            {
                List<string> result;
                if (seach.Length > 2)
                {
                    result = ResultSeach(seach);
                    int itemHeight = 14;
                    if(enable) itemHeight = 40;
                    Update(result, enable, itemHeight);
                }
                else
                {
                    result = new List<string>();
                    result.Add("Введите запрос, к бд подключенно");
                    Update(result, false, 14);
                }
            }
            else
            {
                List<string> result = new List<string>();
                result.Add(error);
                Update(result, false,14);
            }
           
        }

        private string QueryBilder(string query)
        {
            string result;
            Regex regexCyrillic = new(@"\p{IsCyrillic}+", RegexOptions.IgnoreCase);
            Regex regexNumrable = new(@"\d+", RegexOptions.IgnoreCase);
            MatchCollection jjj = regexNumrable.Matches(query);
            if (regexCyrillic.Matches(query).Count > 0)
            {
                result = "SELECT dbo._RES_COLL_SMS00001.Name, dbo._RES_COLL_SMS00001.UserName, dbo.v_R_User.Full_User_Name0, dbo._RES_COLL_SMS00001.LastActiveTime FROM dbo.v_R_User JOIN dbo._RES_COLL_SMS00001 ON dbo.v_R_User.User_Name0=dbo._RES_COLL_SMS00001.UserName WHERE LOWER(dbo.v_R_User.Full_User_Name0) LIKE LOWER('%" + query + "%') LIMIT 15";
                mode = Mode.Username;
            }
            else if(regexNumrable.Matches(query).Count > 0)
            {   
                result = "SELECT dbo._RES_COLL_SMS00001.Name, dbo._RES_COLL_SMS00001.UserName, dbo.v_R_User.Full_User_Name0, dbo._RES_COLL_SMS00001.LastActiveTime FROM dbo._RES_COLL_SMS00001 LEFT JOIN dbo.v_R_User ON dbo._RES_COLL_SMS00001.UserName = dbo.v_R_User.User_Name0 WHERE LOWER(dbo._RES_COLL_SMS00001.Name) LIKE LOWER('%" + query + "%') LIMIT 15";
                mode = Mode.PCname;
            }
            else
            {
                result = "SELECT dbo._RES_COLL_SMS00001.Name, dbo._RES_COLL_SMS00001.UserName, dbo.v_R_User.Full_User_Name0, dbo._RES_COLL_SMS00001.LastActiveTime FROM dbo._RES_COLL_SMS00001 LEFT JOIN dbo.v_R_User ON dbo._RES_COLL_SMS00001.UserName = dbo.v_R_User.User_Name0 WHERE LOWER(dbo._RES_COLL_SMS00001.Name) LIKE LOWER('%" + query + "%') OR LOWER(dbo._RES_COLL_SMS00001.UserName) LIKE LOWER('%" + query + "%') LIMIT 15" +
                    ""; ;
                mode = Mode.Login;
            }
            return result;
        }
        public List<string> ResultSeach(string seach)
        {
            int y = 0;
            comps.Clear();
            List<string> result = new List<string>();
            if (Connection.State == ConnectionState.Open)
            {
                try
                {
                    string sql = QueryBilder(seach);
                    MySqlCommand sqlCom = new MySqlCommand(sql, Connection);
                    // Connection.Open();
                    sqlCom.ExecuteNonQuery();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    DataRow[] myData = dt.Select();
                    for (int i = 0; i < myData.Length; i++)
                    {
                        IComp comp = new CompId(myData[i].ItemArray[0].ToString());
                        comp.SetName(myData[i].ItemArray[1].ToString());
                        comp.SetDescription(myData[i].ItemArray[2].ToString());
                        comps.Add(comp);
                        result.Add("ПК:"+ comp.GetNetNameStr() + "   Логин:" + comp.GetName() + "\r\n" + comp.GetDescription() + "\r\nLastLogin:" + myData[i].ItemArray[3].ToString());
                        ++y;
                    }
                    enable = true;
                }
                catch
                {
                    y = 1;
                    enable = false;
                    result.Clear();
                    result.Add("Ошибка выполнения запроса");
                }

            }
            if (y == 0)
            {
                enable = false;
                result.Add("Ничего не найдено");
            }

                return result;
        }
        public void Activate()
        {
            if (Connection == null)
            {
                string stringConnect = "server=" + SGlobalSetting.settingSCCM.server + ";database=" + SGlobalSetting.settingSCCM.dataBase + ";" + AuthType.AuthString() + ";charset=utf8";
                try
                {
                    Connection = new MySql.Data.MySqlClient.MySqlConnection(stringConnect);
                    Connection.Open();
                    Console.WriteLine("Подключились");
                    error = "Подключенно";
                }
                catch
                {
                    Console.WriteLine("Повторное бы подключение");
                    error = "Не удалось подключиться к базе";
                }
            }
            
        }

        public void Deactivate()
        {
            Connection.Close();
            Connection = null;
        }

        public IComp Result(int index)
        {
            return comps[index];
        }
        public string ResultString(int index)
        {
            switch (mode)
            {
                case Mode.Login:
                    return comps[index].GetName();
                case Mode.Username:
                    return comps[index].GetDescription();
                case Mode.PCname:
                    return comps[index].GetNetNameStr();
            }
            return "";
        }
        public string CheckConnect(string server, string basa)
        {
            if (Connection == null)
            {
                string stringConnect = "server=" + server + ";database=" + basa + ";" + AuthType.AuthString();
                try
                {
                    Connection = new MySql.Data.MySqlClient.MySqlConnection(stringConnect);
                    Connection.Open();
                    error = "Подключенно";
                }
                catch
                {
                    error = "Не удалось подключиться к серверу";
                }
            }
            if (Connection.State == ConnectionState.Open && Connection != null)
            {
                try
                {
                    string sql = "SELECT * FROM dbo._RES_COLL_SMS00001 LIMIT 1";
                    MySqlCommand sqlCom = new MySqlCommand(sql, Connection);
                    sqlCom.ExecuteNonQuery();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    DataRow[] myData = dt.Select();
                    if(myData.Length > 0)
                    {
                        error = "Соединие успешно установленно";
                    }
                    
                }
                catch
                {
                  error = "Ошибка выполнения запроса \nКакая то не правильная база";
                }

            }
            return error;
        }

    }
}
