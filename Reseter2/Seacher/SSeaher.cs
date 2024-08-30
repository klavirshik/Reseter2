using Reseter2.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.Seacher
{
    internal static class SSeaher
    {
        public static ISeaherMetod seaherMetod;
        public static void LoadSetting()
        {
            if(SGlobalSetting.settingSCCM.on)
            {
                seaherMetod = new SeachSCCM();
            }
            else
            {
                seaherMetod = new SeahcLocal();
            }
        }
    }
}
