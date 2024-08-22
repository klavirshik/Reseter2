using Reseter2.History;
using Reseter2.Setting;
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
        private int Timeout;
        private PingResult PingResult = new PingResult(0, 0, null, false);
        public StatusRebooting(ReseterTask reseterTask, int timeout = 0) : base(reseterTask)
        {
            resetertask.SetNameStage("Перезагрузка", 2);
            Timeout = timeout;
        }

        public override Task<PingResult> Tick()
        {
            PingResult = resetertask.Ping();
            return Task.FromResult(PingResult);
        }
        public override void Next()
        {
            if (PingResult.Succes)
            {
                TimeCount++;
            }
            if (TimeCount > SGlobalSetting.settingReboot.timeCheckBeforReboot)
            {
                resetertask.StatusTask = new StatusRebootSucces(resetertask);
                HistoryList.Updated();
            }
            if (PingResult.TimedOut == true)
            {
                Timeout++;
            }
            if (Timeout > SGlobalSetting.settingReboot.timeOutReboot)
            {
                resetertask.StatusTask = new StatusRebootError(resetertask, "Error UP");
                HistoryList.Updated();
            }

        }
        public override string GetName()
        {
            return "Rebooting";
        }
    }
}
