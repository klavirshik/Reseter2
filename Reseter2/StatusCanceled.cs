using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class StatusCanceled : AStatusTask
    {
        private PingResult PingResult;
        public StatusCanceled(ReseterTask reseterTask) : base(reseterTask)
        {
            resetertask.SetNameStage("Отмененно", 4);
            resetertask.historyItem.SetEndTime(DateTime.Now);
            PingResult = resetertask.Ping();
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
            return "Canceled";
        }
    }
}