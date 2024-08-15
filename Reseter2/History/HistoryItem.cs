using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Reseter2.History
{

    [Serializable]
    internal class HistoryItem
    {
        private IComp comp;
        [NonSerialized]
        private ReseterTask task;
        [NonSerialized]
        private AStatusTask statusTask;
        private DateTime startTime;
        private string statusName;
        private DateTime endTime;
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

        public IComp GetComp()
        {
            return comp;

        }

        public void SetEndTime(DateTime endTime)
        {
            this.endTime = endTime;
        }

        public void ClearTask()
        {
            this.task = null;
            this.statusTask = null;
        }

        public string NameNode()
        {
            string buf;
            if (comp.GetName() == null)
            {
                buf = comp.GetNetNameStr();
            }
            else
            {
                buf = comp.GetName();
                if (comp.GetNetNameStr() != null) buf += "(" + comp.GetNetNameStr() + ")";

            }
            return buf;
        }
        public string ToStr
        {

            get {
                if (this.task != null)
                {
                    this.statusTask = this.task.StatusTask;
                    this.statusName = this.statusTask.GetName();
                }
                string name = NameNode();
                name = name.Length > 25 ? name.Substring(0,25): name;
                string output = string.Format("{0,17:dd.MM.yy HH:mm:ss} {1,-25} {2,-9} {3,8:HH:mm:ss}", startTime, name, this.statusName, endTime);
                return output;
            }
        }
    }
}
