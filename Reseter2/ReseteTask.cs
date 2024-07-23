using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
     class ReseterTask
    {
        private Task<PingResult> task;
        public IComp Comp { get; }
        public AStatusTask StatusTask { get; set; }
        private TaskControl taskControl;
        private Pinger Pingers;
        public Stopwatch sw = new Stopwatch();
        public PingResult pingResult;


        public ReseterTask(IComp comp, TaskControl taskCntrl)
        {
            Comp = comp;
            taskControl = taskCntrl;
            StatusTask = new StatusPreReboot(this);
            Pingers = new Pinger(Comp.GetResetName());
        }
        
        public async Task Tick()
        {
            if (task != null)
            {
                if (task.IsCompleted){
                    //this.DataContrl(Ping().ToString(), Timeout().ToString());
                    pingResult = await task;
                    taskControl.DataContrl(pingResult.Ping.ToString() + "ms", pingResult.TimeoutPing.ToString(), pingResult.Ip, sw.Elapsed);
                    StatusTask.Next();
                    task = Task.Run(StatusTask.Tick);
                }
            }
            else
            {
                task = Task.Run(StatusTask.Tick);
                   
            }

            taskControl.TimeContrl(sw.Elapsed);
            
        }

        public string GetName()
        {
            return Comp.GetName();
        }

        public void RebootStop()
        {
            StatusTask.Stop();
        }

        public void RebootReturn()
        {
            StatusTask.RebootReturn();
        }

        public void SetNameStage(string nameStage)
        {
            taskControl.SetNameStage(nameStage);
        }
        public PingResult Ping()
        {
            return Pingers.PingHost();
        }

        public int Timeout() { 
            return Pingers.Timeout();
        }
        
        public void DataContrl(string ping, string timeout)
        {
          //  taskControl.Invoke(DataChange);
          //  DataChange.Invoke(ping, timeout);
        }
        private void Clear()
        {
            Reseter.Clear(this, taskControl);
        }


    }
}
