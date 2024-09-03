using MySql.Data.MySqlClient;
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
using static Reseter2.Seacher.SeahcLocal;

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
        public void Change(ResultUpdate sender, string seach)
        {
            Activate();
            Update = sender;
            if (Connection.State == ConnectionState.Open)
            {
                
                if (seach.Length > 2)
                {

                    Update(ResultSeach(seach), enable);
                }
                else
                {
                    List<string> result = new List<string>();
                    result.Add("Введите запрос, к бд подключенно");
                    Update(result, false);
                }
            }
            else
            {
                List<string> result = new List<string>();
                result.Add(error);
                Update(result, false);
            }
           
        }

        private string QueryBilder(string query)
        {
            string result = "";
            Regex regexCyrillic = new(@"\p{IsCyrillic}*", RegexOptions.IgnoreCase);
            Regex regexNumrable = new(@"\d*", RegexOptions.IgnoreCase);
            if (regexCyrillic.Matches(query).Count > 0)
            {
                result = "SELECT * FROM " + SGlobalSetting.settingSCCM.dataBase + " WHERE pcname LIKE '%" + query + "%'";
            }
            else if(regexNumrable.Matches(query).Count > 0)
            {
                result = "SELECT * FROM " + SGlobalSetting.settingSCCM.dataBase + " WHERE pcname LIKE '%" + query + "%'";
            }
            else
            {
                result = "SELECT * FROM " + SGlobalSetting.settingSCCM.dataBase + " WHERE login LIKE '%" + query + "%'";
            }
            return null;
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
                        IComp comp = new CompId(myData[i].ItemArray[1].ToString());
                        comp.SetName(myData[i].ItemArray[2].ToString());
                        comps.Add(comp);
                        result.Add(comp.GetName() + "(" + comp.GetNetNameStr() + ")");
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
                string stringConnect = "server=" + SGlobalSetting.settingSCCM.server + ";database=" + SGlobalSetting.settingSCCM.dataBase + ";" + AuthType.AuthString();
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
    }
}
