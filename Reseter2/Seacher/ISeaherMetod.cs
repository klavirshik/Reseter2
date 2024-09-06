using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Reseter2.Seacher.SeahcLocal;

namespace Reseter2.Seacher
{
    internal interface ISeaherMetod
    {
        public void Change(ResultUpdate sender, string seach);
        public IComp Result(int index);
        public string ResultString(int index);

    }
}
