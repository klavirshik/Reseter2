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
            cb_create.Items.Add("Категория");
            cb_create.Items.Add("Компьютер");
            cb_create.SelectedItem = 0;

        }


        public BilderWords(WordsCategory category):base()
        {
            
        }
        public BilderWords(WordsComp item) : base()
        {

        }

      

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is WordsComp)
            {
                WordsComp wordsComp = (WordsComp)e.Node.Tag;
                control = new WordsEditCompControl(wordsComp);
                panel1.Controls.Add(control);
            }
            if (e.Node.Tag is WordsCategory)
            {
                WordsCategory wordsCategory = (WordsCategory)e.Node.Tag;
                control = new WordsEditCategoryControl(wordsCategory);
                panel1.Controls.Add(control);
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if(control != null)
            {
                panel1.Controls.Remove(control);
                control.Dispose();
            }
            
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            switch (cb_create.SelectedIndex)
            {
                case 0:
                    WordsList.AddCategory(new WordsCategory("Новая категория"), WordsList.MainCategory);
                    break;
                case 1:
                    WordsList.AddItem(new WordsComp(new CompId("Новый ПК")), WordsList.MainCategory);
                    break;
            }
            treeView1.Nodes.Clear();
            treeView1.Nodes.AddRange(WordsList.ListNodes());
        }
    }
}
