using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
     class ReseterTask
    {
        private IComp Comp;
        private AStatusTask StatusTask;
        private TaskControl taskControl;

        public ReseterTask(IComp comp, TaskControl taskCntrl)
        {
            Comp = comp;
            taskControl = taskCntrl;
            StatusTask = new StatusPreReboot(this);
        }
        public string GetName()
        {
            return Comp.GetName();
        }

        public void Tick()
        {
            StatusTask.Tick();
        }

        public void DataContrl(string srt)
        {
            taskControl.DataContrl(srt);
        }
        private void Clear()
        {
            Reseter.Clear(this, taskControl);
        }


    }
}
