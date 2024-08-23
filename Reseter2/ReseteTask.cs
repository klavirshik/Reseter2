using Reseter2.History;
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
        public DateTime StartTime = DateTime.Now;
        public IComp Comp { get; }
        public AStatusTask StatusTask { get; set; }
        public TaskControl taskControl;
        private Pinger Pingers;
        public Stopwatch sw = new Stopwatch();
        public PingResult pingResult;
        public HistoryItem historyItem;
        


        public ReseterTask(IComp comp, TaskControl taskCntrl)
        {

            Comp = comp;
            taskControl = taskCntrl;
            if (comp.GetResetName() == null || comp.GetResetName().Length == 0)
            {
                //Pingers = new Pinger("");
                Comp.SetName("Не заданно");
                Comp.SetNetName("Не заданно");
                Pingers = new Pinger(Comp.GetResetName());
                StatusTask = new StatusPreReboot(this);
                historyItem = HistoryList.Add(this);
                StatusTask = new StatusRebootError(this, "Uncorrect");

            }
            else
            {
                Pingers = new Pinger(Comp.GetResetName());
                StatusTask = new StatusPreReboot(this);
                historyItem = HistoryList.Add(this);
                
            }
            
        }
        
        public async Task Tick()
        {
            if (task != null)
            {
                if (task.IsCompleted){
                    //this.DataContrl(Ping().ToString(), Timeout().ToString());
                    pingResult = await task;

                    string p;
                    if (pingResult.TimedOut)
                    {
                        p = "----";
                    }
                    else
                    {
                        p = pingResult.Ping.ToString() + "ms";
                    }
                    taskControl.DataContrl(p, pingResult.TimeoutPing.ToString(), pingResult.Ip, sw.Elapsed);
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

        public void SetNameStage(string nameStage, int indexImg, bool pauseOn = true)
        {
            taskControl.SetNameStage(nameStage, indexImg, pauseOn);
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
