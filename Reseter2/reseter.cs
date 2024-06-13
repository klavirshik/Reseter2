using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal static class Reseter
    {
        private static List<ReseterTask> list_task;
       

        public static void AddTask(IComp compName)
        {
            list_task.Add(new ReseterTask(compName));
        }

        public static void Clear(ReseterTask reseterTask)
        {
            list_task.Remove(reseterTask);
        }
    }
}
