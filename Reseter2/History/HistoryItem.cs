using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Reseter2.History
{
    

    internal class HistoryItem
    {
        private IComp comp;
        private ReseterTask task;
        private AStatusTask statusTask;
        private DateTime startTime;
        private string statusName;
        public HistoryItem(IComp comp, AStatusTask statusTask, DateTime startTime)
        {
            this.comp = comp;
            this.statusTask = statusTask;
            this.startTime = startTime;
        }
        public HistoryItem(ReseterTask task)
        {
            this.comp = task.Comp;
            this.task = task;
            this.statusTask = task.StatusTask;
            this.startTime = task.StartTime;
        }
        public SHistory GetData() 
        {
            return new SHistory(comp.GetName(), startTime.ToShortTimeString(), statusTask.GetName());
        
        }

        public void ClearTask()
        {
            this.task = null;
            this.statusTask = null;
        }
        public string ToStr
        {

            get {
                if (this.task != null)
                {
                    this.statusTask = this.task.StatusTask;
                    this.statusName = this.statusTask.GetName();
                }
                string output = string.Format("{0,5}|{1,10}|{2,10}", startTime.ToString(), comp.GetResetName(), this.statusName, startTime.ToString());
                return output;
            }
        }
    }
}
