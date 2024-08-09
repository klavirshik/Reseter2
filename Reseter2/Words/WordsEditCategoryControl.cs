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
        private WordsCategory wordsCategory;
        private TreeNode treeNode;
        public WordsEditCategoryControl()
        {
            InitializeComponent();
        }

        public WordsEditCategoryControl(WordsCategory wordscategory, TreeNode treenode)
        {
            InitializeComponent();
            lb_name.Text = wordscategory.GetName();
            wordsCategory = wordscategory;
            treeNode = treenode;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WordsEditCategoryControl_VisibleChanged(object sender, EventArgs e)
        {
            treeNode.Text = lb_name.Text;
            wordsCategory.SetName(lb_name.Text);
        }
    }
}
