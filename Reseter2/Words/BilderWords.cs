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
    internal partial class BilderWords : Form
    {
        private Control control;
        public BilderWords()
        {
            InitializeComponent();
            WordsCategory WCvebinar = new WordsCategory("Вебинарные");
            WordsList.AddCategory(WCvebinar, WordsList.MainCategory);
            WordsList.AddItem(new WordsComp(new CompId("8.8.8.8")), WCvebinar);
            WordsList.AddItem(new WordsComp(new CompId("1ma00234")), WordsList.MainCategory);
            WordsList.AddItem(new WordsComp(new CompId("1ma003333")), WordsList.MainCategory);
           // TreeNode trno = new TreeNode("main");
           
            
            treeView1.Nodes.AddRange(WordsList.ListNodes());
            //trno.ImageIndex = 1;
            

        }


        public BilderWords(WordsCategory category):base()
        {
            
        }
        public BilderWords(WordsComp item) : base()
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_category.Checked)
            {

            }
            else
            {

            }
         }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is WordsComp)
            {
                WordsComp wordsComp = (WordsComp)e.Node.Tag;
                control = new WordsEditCompControl();
                groupBox1.Controls.Add(control);
            }
            if (e.Node.Tag is WordsCategory)
            {
                WordsCategory wordsCategory = (WordsCategory)e.Node.Tag;
                control = new WordsEditCategoryControl();
                groupBox1.Controls.Add(control);
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if(control != null)
            {
                groupBox1.Controls.Remove(control);
                control.Dispose();
            }
            
        }
    }
}
