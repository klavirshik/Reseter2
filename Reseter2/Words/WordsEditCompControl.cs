using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.Words
{

    [DefaultEvent(nameof(WordsEditCompControl))]
    internal partial class WordsEditCompControl : UserControl
    {

        public WordsEditCompControl()
        {
            InitializeComponent();
        }
        public WordsEditCompControl(WordsComp wordsComp)
        {
            InitializeComponent();
            lb_name.Text = wordsComp.GetName();
            lb_ip.Text = wordsComp.GetIP();
            lb_description.Text = wordsComp.GetDescription();
        }
    }
}
