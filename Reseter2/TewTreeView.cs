using Reseter2.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2
{
    [DefaultEvent(nameof(NewTreeView))]
    class NewTreeView:TreeView
    {
        protected override void WndProc(ref Message m)
        { 
            if(m.Msg == 0x0203)
            {
                Point localPos = this.PointToClient(Cursor.Position);
                var hitTestInfo = this.HitTest(localPos);
                if (hitTestInfo.Location == TreeViewHitTestLocations.StateImage)
                {
                    m.Msg = 0x0201;
                }
            }
            base.WndProc(ref m);
        }
        
    }
}
