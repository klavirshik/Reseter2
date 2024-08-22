using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class StatusRebootError : AStatusTask
    {
        private string _error;
        private PingResult PingResult = new PingResult(0, 0, null, false);
        public StatusRebootError(ReseterTask reseterTask, string error = "Error") : base(reseterTask)
        {
            _error = error;
            string messges = "Ошибка перезагрузки";
            if (error != "Error") messges = messges + "(" + error + ")";
            resetertask.SetNameStage(messges, 5, false);
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

            return _error;
        }
    }
}
