using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2
{
    internal static class Reseter
    {
        private static List<ReseterTask> list_task = new List<ReseterTask>();
        private static Panel flow_conteiner;
       
        public static void SetForm(Panel flow_cntr)
        {
            flow_conteiner = flow_cntr;
        }
        public static void AddTask(String name)
        {
            CompId compid = new CompId(name);
            AddTask(compid);
        }
        public static void AddTask(IComp compName)
        {

            TaskControl taskControl = new TaskControl();
            ReseterTask reseterTask = new ReseterTask(compName, taskControl);
            taskControl.Intit(reseterTask);
            flow_conteiner.Controls.Add(taskControl);
            list_task.Add(reseterTask);
        }

        public static void Clear(ReseterTask reseterTask, TaskControl taskControl)
        {
            flow_conteiner.Controls.Remove(taskControl);
            list_task.Remove(reseterTask);

        }
        public static void Tick()
        {
            foreach (var item in list_task)
            {
                item.Tick();
            }
        }
    }
}
