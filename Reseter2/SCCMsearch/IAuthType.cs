using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.SCCMsearch
{
    internal interface IAuthType
    {
       public string Name { get; }
       public string Password { get; }
       public string AuthString();
    }
}
