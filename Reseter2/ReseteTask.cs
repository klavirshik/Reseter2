using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class ReseterTask
    {
        private IComp Comp;
        private AStatusTask StatusTask;


        public ReseterTask(IComp comp)
        {
            Comp = comp;
            StatusTask = new StatusPreReboot(this);
        }
        private void Clear()
        {
            Reseter.Clear(this);
        }

    }
}
