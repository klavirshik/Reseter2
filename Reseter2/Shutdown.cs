using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    class Shutdown
    {
        public static void Restart()
        {
            StartShutDown("-f -r -t 5");
        }
        public static void RestartPC(string param)
        {
            if (param.Length > 0)
            {
                StartShutDown("-r -m \\\\" + param + "-f -t 5");
            }
            
        }
        public static void LogOff()
        {
            StartShutDown("-l");
        }

        public static void Shut()
        {
            StartShutDown("-f -s -t 5");
        }
        private static void StartShutDown(string param)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = "cmd";
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Arguments = "/C shutdown " + param;
            Process.Start(proc);
        }
    }
}
