using Reseter2.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Reseter2
{
    internal class StatusReboot : AStatusTask
    {
        private int TimeCount;

        private PingResult PingResult = new PingResult(0, 0, null, false);
        public StatusReboot(ReseterTask reseterTask) : base(reseterTask)
        {
            resetertask.SetNameStage("Отправка в перезагрузку");
            Shutdown.RestartPC(reseterTask.Comp.GetResetName());
        }

        public override Task<PingResult> Tick()
        {
            PingResult = resetertask.Ping();
            return Task.FromResult(PingResult);
        }
        public override void Next()
        {
            if (PingResult.TimedOut == true)
            {
                TimeCount++;
            }
            if (TimeCount > 3)
            {
                resetertask.StatusTask = new StatusRebooting(resetertask);
                HistoryList.Updated();
            }
        }
        public override string GetName()
        {
            return "Отправка команды";
        }
    }
}
