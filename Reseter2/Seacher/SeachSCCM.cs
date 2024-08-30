using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Reseter2.SCCMsearch;
using Reseter2.Setting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Reseter2.Seacher.SeahcLocal;

namespace Reseter2.Seacher
{
    internal class SeachSCCM : ISeaherMetod
    {
        private MySql.Data.MySqlClient.MySqlConnection Connection;
        private IAuthType AuthType;
        private ResultUpdate Update;
        private bool enable;
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
            if (seach.Length > 2)
            {

               Update(ResultSeach(seach), enable);
            }
            else
            {
                List<string> result = new List<string>();
                result.Add("Введите запрос");
                Update(result, false);
            }
        }
        public List<string> ResultSeach(string seach)
        {
            
            string sql = "SELECT * FROM " + SGlobalSetting.settingSCCM.dataBase + " WHERE pcname LIKE " + seach;
            MySqlCommand sqlCom = new MySqlCommand(sql, Connection);
           // Connection.Open();
            sqlCom.ExecuteNonQuery();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            var myData = dt.Select();
            //for (int i = 0; i < myData.Length; i++)
            //{
            //    for (int j = 0; j < myData[i].ItemArray.Length; j++)
            //        richTextBox1.Text += myData[i].ItemArray[j] + " ";
            //    richTextBox1.Text += "\n";
            //}
            return null;
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
                }
                catch
                {
                    Console.WriteLine("Повторное бы подключение");
                }
            }
            
        }

        public void Deactivate()
        {
            Connection.Close();
            Connection = null;
        }

        public IComp Result(int Index)
        {
            return null;
        }
    }
}
