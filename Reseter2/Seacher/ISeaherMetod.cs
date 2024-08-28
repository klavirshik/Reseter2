using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.Seacher
{
    internal interface ISeaherMetod
    {
        public void Change(string seach);
        public List<string> ResultSeach();
        public IComp Result(int index);
    }
}
