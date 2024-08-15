using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class StatusRebootError : AStatusTask
    {
        private PingResult PingResult = new PingResult(0, 0, null, false);
        public StatusRebootError(ReseterTask reseterTask) : base(reseterTask)
        {
            resetertask.SetNameStage("Ошибка перезагрузки", 5);
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

            return "Error";
        }
    }
}
