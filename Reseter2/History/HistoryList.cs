using Reseter2.Setting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.History
{
    [Serializable]
    internal static class HistoryList
    {
        static public List<HistoryItem> Hitem = new List<HistoryItem>();
        //static private FormHistory formHistory;

        public delegate void UpdateMethod();
        static public event UpdateMethod Update;
        static public HistoryItem Add(ReseterTask reseterTask)
        {

            HistoryItem historyItem = new HistoryItem(reseterTask);
            Hitem.Insert(0, historyItem);
            ClearFirst();
            Update();
            
            return historyItem;
           
        }
        static public void Updated()
        {
            Update();
        }
        static public void Clear()
        {
            Hitem.Clear();
        }

        static public void ClearFirst()
        {
            if(Hitem.Count > SGlobalSetting.settingReboot.sizeHistoryItem) 
            {
                Hitem.RemoveAt(Hitem.Count() - 1);
                ClearFirst();
            }
            
            
        }
    }
}
