using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class StatusRebootSucces : AStatusTask
    {
        private PingResult PingResult;
        public StatusRebootSucces(ReseterTask reseterTask) : base(reseterTask)
        {
            resetertask.SetNameStage("Успешно перезагруженно", 7);
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
            return "Успешно";
        }
    }
}
