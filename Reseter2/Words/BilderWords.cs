using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reseter2.Words
{
    internal partial class BilderWords : Form
    {
        private Control control;
        public BilderWords()
        {
            InitializeComponent();


            WordsCategory WCvebinar = new WordsCategory("Вебинарные");
            WordsList.AddItem(WCvebinar, WordsList.MainCategory);
            WordsList.AddItem(new WordsComp(new CompId("8.8.8.8")), WCvebinar);
            WordsList.AddItem(new WordsComp(new CompId("1ma00234")), WordsList.MainCategory);
            WordsList.AddItem(new WordsComp(new CompId("1ma003333")), WordsList.MainCategory);
            //// TreeNode trno = new TreeNode("main");


            treeView1.Nodes.AddRange(WordsList.ListNodes());
            //trno.ImageIndex = 1;
            cb_create.Items.Add("Категория");
            cb_create.Items.Add("Компьютер");
            cb_create.SelectedIndex = 0;
            treeView1.ItemDrag += new ItemDragEventHandler(TreeView1_ItemDrag);
            treeView1.DragEnter += new DragEventHandler(TreeView1_DragEnter);
            treeView1.DragOver += new DragEventHandler(TreeView1_DragOver);
            treeView1.DragDrop += new DragEventHandler(TreeView1_DragDrop);


        }

        private void TreeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
            //throw new NotImplementedException();
        }

        private void TreeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        private void TreeView1_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = treeView1.PointToClient(new Point(e.X, e.Y));
            treeView1.SelectedNode = treeView1.GetNodeAt(targetPoint);
        }
        private void TreeView1_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = treeView1.PointToClient(new Point(e.X, e.Y));
            TreeNode node = treeView1.GetNodeAt(targetPoint);
            int PointH = targetPoint.Y - node.Bounds.Y;
            //treeView1.GetNodeAt(targetPoint).Bounds.Top.ToString()
            //e.Y.ToString()
           
            //node.Bounds.Y
            
            
            MessageBox.Show(PointH.ToString());
           

        }

        public BilderWords(WordsCategory category):base()
        {
            
        }
        public BilderWords(WordsComp item) : base()
        {

        }

      

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.Tag is WordsComp)
                {
                    WordsComp wordsComp = (WordsComp)e.Node.Tag;
                    control = new WordsEditCompControl(wordsComp, e.Node);
                    panel1.Controls.Add(control);
                }
                if (e.Node.Tag is WordsCategory)
                {
                    WordsCategory wordsCategory = (WordsCategory)e.Node.Tag;
                    control = new WordsEditCategoryControl(wordsCategory, e.Node);
                    panel1.Controls.Add(control);
                }
            }
           
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {

            if(control != null)
            {
                control.Visible = false;
                control.Dispose();
            }
            

        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            WordsCategory ParentCategory;
            TreeNode selectNode = treeView1.SelectedNode;
            TreeNodeCollection ParentNodes;
            int index = 0;
            if(selectNode == null)
            {
                ParentCategory = WordsList.MainCategory;
                ParentNodes = treeView1.Nodes;
            }
            else if(selectNode.Tag is WordsCategory)
            {
                ParentCategory = (WordsCategory)selectNode.Tag;
                ParentNodes = selectNode.Nodes;
                selectNode.Expand();
            }
            else if (selectNode.Parent == null)
            {
                 ParentCategory = WordsList.MainCategory;
                 ParentNodes = treeView1.Nodes;
                 index = selectNode.Index+1;
            }
            else
            {
                 ParentCategory = (WordsCategory)selectNode.Parent.Tag;
                ParentNodes = selectNode.Parent.Nodes;
                index = selectNode.Index+1;
            }
            

            
            object item = null;
            TreeNode treeNode = new TreeNode();
            switch (cb_create.SelectedIndex)
            {
                case 0:
                    item = new WordsCategory("Новая категория");
                    WordsList.InsertItem(index, (WordsCategory)item, ParentCategory);
                    treeNode.ImageIndex = 1;
                    treeNode.Text = "Новая категория";
                    break;
                case 1:
                    item = new WordsComp(new CompId("Новый ПК"));
                    WordsList.InsertItem(index, (WordsComp)item, ParentCategory);
                    treeNode.ImageIndex = 0;
                    treeNode.Text = "Новый ПК";
                    break;
            }   
           treeNode.Tag = item;
           ParentNodes.Insert(index,treeNode);
          
           
          
        }

        private void BilderWords_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool save = false;
        }

        private void bt_deleteItem_Click(object sender, EventArgs e)
        {
            
            TreeNode selectNode = treeView1.SelectedNode;
            if (selectNode == null) return;
            WordsCategory ParentCategory;
            TreeNodeCollection ParentNodes;
            treeView1.SelectedNode = null;
            control.Visible = false;
            control.Dispose();
            if (selectNode.Parent == null)
            {
                ParentCategory = WordsList.MainCategory;
                ParentNodes = treeView1.Nodes;
            }
            else
            {
                ParentCategory = (WordsCategory)selectNode.Parent.Tag;
                ParentNodes = selectNode.Parent.Nodes;



            }
            

            if (selectNode.Tag == null) return;
            IWordsItem wordsItem = (IWordsItem)selectNode.Tag;
            
            ParentCategory.DeleteItem(wordsItem);
            ParentNodes.Remove(selectNode);
           
        }
    }
}
