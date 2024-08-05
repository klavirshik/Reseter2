using Reseter2.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class StatusPreReboot : AStatusTask
    {
        private int time;
        private PingResult PingResult = new PingResult(0,0,null, false);
        public StatusPreReboot(ReseterTask reseterTask) : base(reseterTask)
        {
            resetertask.SetNameStage("Проверка связи");
            resetertask.sw.Restart();
        }

        public override Task<PingResult> Tick()
        {
            time++;
            PingResult = resetertask.Ping();
            return Task.FromResult(PingResult);
           // return resetertask.DataContrl(pingResult.Ping.ToString(), pingResult.Ping.ToString());
            
        }
        public override void Next()
        {
                if (PingResult.TimedOut == false)
                {
                resetertask.StatusTask = new StatusReboot(resetertask);
                HistoryList.Updated();
            }
            
                
        }
        public override string GetName()
        {
            return "Проверка связи";
        }

    }
}