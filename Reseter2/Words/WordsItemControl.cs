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
    public partial class WordsItemControl : UserControl
    {

        public WordsItemControl()
        {
            InitializeComponent();
        }

        private void WordsItemControl_Load(object sender, EventArgs e)
        {

        }
   
    }
}
