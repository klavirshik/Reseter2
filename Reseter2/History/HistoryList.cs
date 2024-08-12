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
    }
}
