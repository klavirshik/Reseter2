using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class StatusPreReboot : AStatusTask
    {
        public StatusPreReboot(ReseterTask reseterTask) : base(reseterTask)
        {
        }

        public override void Next()
        {

        }
        public override void Stop()
        {

        }
    }
}