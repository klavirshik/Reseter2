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
        public abstract void Stop();
        public abstract void Next();
    }
}
