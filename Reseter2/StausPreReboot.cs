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
        public StatusPreReboot(ReseterTask reseterTask) : base(reseterTask)
        {
            resetertask.SetNameStage("Проверка связи");
        }

        public override Task<PingResult> Tick()
        {
            time++;
            PingResult result = resetertask.Ping();
            if (result.Ping > 0)
            {
                resetertask.StatusTask = new StatusReboot(resetertask);
            }
            return Task.FromResult(result);
           // return resetertask.DataContrl(pingResult.Ping.ToString(), pingResult.Ping.ToString());
            
        }
        public override void Next()
        {

        }
        public override void Stop()
        {

        }
    }
}