using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.History
{
    internal struct SHistory
    {
        public string Name;
        public string StartTime;
        public string StatusTask;
        public SHistory(string name, string startTime, string statusTask)
        {
            Name = name;
            StartTime = startTime;  
            StatusTask = statusTask;
        }
    }
}
