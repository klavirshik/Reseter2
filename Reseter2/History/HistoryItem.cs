using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.History
{
    

    internal class HistoryItem
    {
        private IComp comp;
        private ReseterTask task;
        private AStatusTask statusTask;
        private DateTime startTime;
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
    }
}
