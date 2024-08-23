using Reseter2.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    abstract class AStatusTask
    {
        protected ReseterTask resetertask;
        public AStatusTask(ReseterTask reseterTask)
        {
            resetertask = reseterTask;
        }
        public abstract Task<PingResult> Tick();
        public abstract void Next();
        public abstract string GetName();
        public void Stop() {
            resetertask.StatusTask = new StatusRebootStop(resetertask);
            HistoryList.Updated();
        }
        public void RebootReturn()
        {
            resetertask.historyItem.SetEndTime(DateTime.Now);
            resetertask.historyItem.ClearTask();
            resetertask.StatusTask = new StatusPreReboot(resetertask);
            resetertask.historyItem = HistoryList.Add(resetertask);
            HistoryList.Updated();
        }
        public abstract int ActionIs();
    }
}
