using Reseter2.History;
using Reseter2.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class StatusPreReboot : AStatusTask
    {
        private int timeOut;
        private PingResult PingResult = new PingResult(0,0,null, false);
        public StatusPreReboot(ReseterTask reseterTask) : base(reseterTask)
        {
            resetertask.SetNameStage("Проверка связи", 0);
            resetertask.sw.Restart();
        }

        public override Task<PingResult> Tick()
        {
            
            PingResult = resetertask.Ping();
            return Task.FromResult(PingResult);
           // return resetertask.DataContrl(pingResult.Ping.ToString(), pingResult.Ping.ToString());
            
        }
        public override void Next()
        {
            if (PingResult.Succes)
            {
                resetertask.StatusTask = new StatusReboot(resetertask);
                HistoryList.Updated();
                return;
            }
            else 
            {
                timeOut++;
            }
            if(timeOut > SGlobalSetting.settingReboot.checkConnect)
            {
                resetertask.StatusTask = new StatusRebootError(resetertask, "Error NET");
                HistoryList.Updated();
            }
                
        }
        public override string GetName()
        {
            return "Check NET";
        }

        public override int ActionIs()
        {
            return 1;
        }

    }
}