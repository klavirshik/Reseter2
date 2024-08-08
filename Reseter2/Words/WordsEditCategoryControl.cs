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
    [DefaultEvent(nameof(WordsEditCategoryControl))]
    internal partial class WordsEditCategoryControl : UserControl
    {
        public WordsEditCategoryControl()
        {
            InitializeComponent();
        }

        public WordsEditCategoryControl(WordsCategory wordsCategory)
        {
            InitializeComponent();
            lb_name.Text = wordsCategory.GetName();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
