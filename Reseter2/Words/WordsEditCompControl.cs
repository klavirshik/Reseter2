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
        private WordsComp wordsComp;
        private TreeNode treeNode;
        public WordsEditCompControl()
        {
            InitializeComponent();
        }
        public WordsEditCompControl(WordsComp wordscomp, TreeNode treenode)
        {
            InitializeComponent();
            lb_name.Text = wordscomp.GetName();
            lb_ip.Text = wordscomp.GetIP();
            lb_description.Text = wordscomp.GetDescription();
            wordsComp = wordscomp;
            treeNode = treenode;
        }
        public void Save()  
        {
           
        }

        private void WordsEditCompControl_VisibleChanged(object sender, EventArgs e)
        {
            treeNode.Text = lb_name.Text;
            wordsComp.Set(lb_name.Text, lb_ip.Text, lb_description.Text);
        }
    }
}
