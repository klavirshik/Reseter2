using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class StatusReboot : AStatusTask
    {
        private int TimeCount;
        public StatusReboot(ReseterTask reseterTask) : base(reseterTask)
        {
           // resetertask.SetNameStage("Перезагрузка");
        }

        public override Task<PingResult> Tick()
        {
            
            PingResult result = resetertask.Ping();
            if (result.Ping == 0)
            {
                TimeCount++;
            }
            if (TimeCount > 2)
            {
                resetertask.StatusTask = new StatusPreReboot(resetertask);
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
