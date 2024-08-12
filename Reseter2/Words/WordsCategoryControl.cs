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
    partial class WordsCategoryControl : UserControl, IWordsContol
    {
        public WordsCategoryControl()
        {
            InitializeComponent();
        }
        public WordsCategoryControl(WordsCategory wordsCategoty)
        {
            InitializeComponent();
            lb_name.Text = wordsCategoty.GetName();
            foreach (IWordsItem item in wordsCategoty.Items())
            {
                if(item is WordsCategory)
                {
                    flow_wordsItem.Controls.Add(new WordsCategoryControl((WordsCategory)item));
                }else if(item is WordsComp)
                {
                    flow_wordsItem.Controls.Add(new WordsItemControl((WordsComp)item));
                }
            }
        }

        public void Add(WordsItemControl wic)
        {
            flow_wordsItem.Controls.Add(wic);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            flow_wordsItem.Visible = !flow_wordsItem.Visible;
            
        }

        private void WordsCategoryControl_Load(object sender, EventArgs e)
        {

        }
    }
}
