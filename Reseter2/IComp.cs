using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal interface IComp
    {
        string GetName();
        string GetResetName();
        IPAddress GetIP();

        void SetIP(IPAddress ip);
        void SetName(string name);
        void SetDescription(string description);

        string GetDescription();

    }
}
