using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.History
{
    internal static class HistoryList
    {
        static private List<HistoryItem> Hitem;
        static private FormHistory formHistory;
        static public HistoryItem Add(ReseterTask reseterTask)
        {
           HistoryItem historyItem = new HistoryItem(reseterTask);
           Hitem.Add(historyItem);
           return historyItem;
        }
        static public void SetControl(FormHistory formhistory)
        {
            formHistory = formhistory; 
        }
        static public void Update()
        {

        }
    }
}
