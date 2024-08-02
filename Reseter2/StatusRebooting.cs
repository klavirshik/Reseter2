using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class StatusRebooting : AStatusTask
    {
        private int TimeCount;
        private PingResult PingResult = new PingResult(0, 0, null, false);
        public StatusRebooting(ReseterTask reseterTask) : base(reseterTask)
        {
            resetertask.SetNameStage("Перезагрузка");
            
        }

        public override Task<PingResult> Tick()
        {
            PingResult = resetertask.Ping();
            return Task.FromResult(PingResult);
        }
        public override void Next()
        {
            if (PingResult.TimedOut == false)
            {
                TimeCount++;
            }
            if (TimeCount > 50)
            {
                resetertask.StatusTask = new StatusRebootSucces(resetertask);
            }
        }
        public override string GetName()
        {
            return "Перезагрузка";
        }
    }
}
