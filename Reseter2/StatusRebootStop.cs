using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class StatusRebootStop : AStatusTask
    {
        private PingResult PingResult;
        public StatusRebootStop(ReseterTask reseterTask) : base(reseterTask)
        {
            resetertask.SetNameStage("Остановленно", 6);
            PingResult = resetertask.pingResult;
            resetertask.historyItem.SetEndTime(DateTime.Now);       
            reseterTask.sw.Stop();
        }

        public override Task<PingResult> Tick()
        {
            return Task.FromResult(PingResult);
        }
        public override void Next()
        {
        }
        public override string GetName()
        {
            return "Stop";
        }
    }
}
