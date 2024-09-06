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

    [DefaultEvent(nameof(WordsItemControl))]
    internal partial class WordsItemControl : UserControl, IWordsContol
    {

        public WordsItemControl()
        {
            InitializeComponent();
        }

        public WordsItemControl(WordsComp wordsComp)
        {
            InitializeComponent();
            lb_ip.Text = wordsComp.GetIP();
            lb_name.Text = wordsComp.GetName();
            lb_dsp.Text = wordsComp.GetDescription();
            
        }

        private void WordsItemControl_Load(object sender, EventArgs e)
        {

        }
   
    }
}
