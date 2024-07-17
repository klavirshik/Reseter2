using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
     class ReseterTask
    {
        private Task task;
        private IComp Comp;
        private AStatusTask StatusTask;
        private TaskControl taskControl;
        private Pinger Pingers;
        public delegate void DataEvents(string ping, string timeout);
        public event DataEvents DataChange;

        public ReseterTask(IComp comp, TaskControl taskCntrl)
        {
            Comp = comp;
            taskControl = taskCntrl;
            StatusTask = new StatusPreReboot(this);
            Pingers = new Pinger(Comp.GetName());
            DataChange += taskControl.DataContrl;
        }
        public string GetName()
        {
            return Comp.GetName();
        }

        public async Task Tick()
        {
            if (task != null)
            {
                if (task.IsCompleted){
                    //this.DataContrl(Ping().ToString(), Timeout().ToString());
                    await task;
                    
                    task = Task.Run(StatusTask.Tick);
                }
            }
            else
            {
                task = Task.Run(StatusTask.Tick);
            }
            
            
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
          //  taskControl.Invoke(DataChange);
            DataChange.Invoke(ping, timeout);
        }
        private void Clear()
        {
            Reseter.Clear(this, taskControl);
        }


    }
}
