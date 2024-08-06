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
    [DefaultEvent(nameof(WordsCategoryControl))]
    partial class WordsCategoryControl : UserControl
    {
        public WordsCategoryControl()
        {
            InitializeComponent();
        }

        public void Add(WordsItemControl wic)
        {
            flow_wordsItem.Controls.Add(wic);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            flow_wordsItem.Visible = !flow_wordsItem.Visible;
            //flow_wordsItem.s
        }
    }
}
