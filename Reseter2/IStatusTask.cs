using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    abstract class AStatusTask
    {
        protected ReseterTask resetertask;
        public AStatusTask(ReseterTask reseterTask)
        {
            resetertask = reseterTask;
        }
        public abstract Task<PingResult> Tick();
        public abstract void Next();
        public void Stop() {
            resetertask.StatusTask = new StatusRebootStop(resetertask);
        }
        public void RebootReturn()
        {
            resetertask.StatusTask = new StatusPreReboot(resetertask);
        }
        
    }
}
