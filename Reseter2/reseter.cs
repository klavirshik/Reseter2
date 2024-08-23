using Reseter2.History;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Reseter2
{
    internal static class Reseter
    {
        private static List<ReseterTask> list_task = new List<ReseterTask>();
        private static Panel flow_conteiner;
        private static Form1 Main;

        public static void SetForm(Panel flow_cntr, Form1 main)
        {
            flow_conteiner = flow_cntr;
            Main = main;
        }
        public static void AddTask(String name)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(name);
                CompId compid = new CompId(ip);
                AddTask(compid);
            }
            catch (FormatException e)
            {
                CompId compid = new CompId(name);
                AddTask(compid);
            }
            catch
            {
                
            }
            
        }

        public static void AddTask(List<IComp> comps)
        {
            foreach (var item in comps)
            {
                AddTask(item);
            }
        }
        public static void AddTask(IComp compName)
        {

            TaskControl taskControl = new TaskControl();
            taskControl.UpdateTree = Main.UpdateTree;
            ReseterTask reseterTask = new ReseterTask(compName, taskControl);
            taskControl.Intit(reseterTask);
            flow_conteiner.Controls.Add(taskControl);
            list_task.Add(reseterTask);
        }

        public static void ClearCanceled()
        {
            foreach (var item in list_task)
            {
                if (item.StatusTask.ActionIs() == 0)
                {
                    flow_conteiner.Controls.Remove(item.taskControl);
                    list_task.Remove(item);
                    ClearCanceled();
                    return;
                }

            }
        }
        
            public static async void Clear(ReseterTask reseterTask, TaskControl taskControl)
        {
            if(!(reseterTask.StatusTask is StatusRebootError ||
               reseterTask.StatusTask is StatusRebootStop  ||
               reseterTask.StatusTask is StatusRebootSucces))
            {
                reseterTask.StatusTask = new StatusCanceled(reseterTask);
                reseterTask.historyItem.SetEndTime(DateTime.Now);
            }
            
            HistoryList.Updated();
            flow_conteiner.Controls.Remove(taskControl);
            list_task.Remove(reseterTask);

        }
        public static void Tick(out int Action, out int Close)
        {
            Action = 0;
            Close = 0;
           
            try
            {
                foreach (var item in list_task)
                {
                
                    item.Tick();
                    if(item.StatusTask.ActionIs() == 1)
                    {
                        Action++;
                    }
                    else
                    {
                        Close++;
                    }
               
                } 
            }
            catch 
                { 
                }

          
        }
    }
}
