using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
     class ReseterTask
    {
        private IComp Comp;
        private AStatusTask StatusTask;
        private TaskControl taskControl;
        private Pinger Pingers;

        public ReseterTask(IComp comp, TaskControl taskCntrl)
        {
            Comp = comp;
            taskControl = taskCntrl;
            StatusTask = new StatusPreReboot(this);
            Pingers = new Pinger(Comp.GetName());
        }
        public string GetName()
        {
            return Comp.GetName();
        }

        public void Tick()
        {
            StatusTask.Tick();
        }

        public long Ping()
        {
            return Pingers.PingHost();
        }

        public int Timeout() { 
            return Pingers.Timeout();
        }
        
        public void DataContrl(string ping, string timeout)
        {
            taskControl.DataContrl(ping, timeout);
        }
        private void Clear()
        {
            Reseter.Clear(this, taskControl);
        }


    }
}
