using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
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
        private bool DragOn; 
        public BilderWords()
        {
            InitializeComponent();
            WordsList.MainCategory.

            WordsCategory WCvebinar = new WordsCategory("Вебинарные");
            WordsList.AddItem(WCvebinar, WordsList.MainCategory);
            WordsList.AddItem(new WordsComp(new CompId("8.8..8")), WCvebinar);
            WordsList.AddItem(new WordsComp(new CompId("8.8.3.8")), WCvebinar);
            WordsList.AddItem(new WordsComp(new CompId("8.8.2.8")), WCvebinar);
            WordsList.AddItem(new WordsComp(new CompId("8.8.1.8")), WCvebinar);
            WordsList.AddItem(new WordsComp(new CompId("1ma00234")), WordsList.MainCategory);
            WordsList.AddItem(new WordsComp(new CompId("1ma003333")), WordsList.MainCategory);
            WordsCategory WCvebinar1 = new WordsCategory("Вебинарные");
            WordsList.AddItem(WCvebinar1, WordsList.MainCategory);
            WordsList.AddItem(new WordsComp(new CompId("8.8.8.8")), WCvebinar1);
            WordsList.AddItem(new WordsComp(new CompId("8.8.8.2")), WCvebinar1);
            WordsList.AddItem(new WordsComp(new CompId("8.8.8.3")), WCvebinar1);
            WordsList.AddItem(new WordsComp(new CompId("8.8.8.1")), WCvebinar1);
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
            DragOn = true;
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
            //throw new NotImplementedException();
        }

        private void TreeView1_DragEnter(object sender, DragEventArgs e)
        {
            DragOn = true;
            e.Effect = e.AllowedEffect;
        }
        private void TreeView1_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = treeView1.PointToClient(new Point(e.X, e.Y));
            treeView1.SelectedNode = treeView1.GetNodeAt(targetPoint);
        }
        private void TreeView1_DragDrop(object sender, DragEventArgs e)
        {
            DragOn = false;
            int indexMod = 0;
            int index = 0;
            Point targetPoint = treeView1.PointToClient(new Point(e.X, e.Y));
            TreeNode selectNode = treeView1.GetNodeAt(targetPoint);
            TreeNode moveNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if(selectNode == null)
            {
               // indexMod = 1;
            }
            else
            {
                int PointH = targetPoint.Y - selectNode.Bounds.Y;   
                if (PointH > 6) indexMod = 1; 
            }

            //if (!((IWordsItem)moveNode.Tag).ChekMove((IWordsItem)selectNode.Tag)) return;

            WordsCategory DstCategory;
            TreeNodeCollection DstNodes;
            
            if (selectNode == null)
            {
                DstCategory = WordsList.MainCategory;
                DstNodes = treeView1.Nodes;
                if(targetPoint.Y < 5)
                {
                    index = 0;
                }
                else
                {
                    index = treeView1.Nodes.Count;
                }
                
            }
            else if (selectNode.Tag is WordsCategory)
            {
                DstCategory = (WordsCategory)selectNode.Tag;
                DstNodes = selectNode.Nodes;
                selectNode.Expand();
               // index = 1;
            }
            else if (selectNode.Parent == null)
            {
                DstCategory = WordsList.MainCategory;
                DstNodes = treeView1.Nodes;
                index = selectNode.Index + indexMod;
            }
            else
            {
                DstCategory = (WordsCategory)selectNode.Parent.Tag;
                DstNodes = selectNode.Parent.Nodes;
                index = selectNode.Index + indexMod;
            }

            WordsCategory SrcCategory;
            TreeNodeCollection SrcNodes;
            if (moveNode == null)
            {
                SrcCategory = WordsList.MainCategory;
                SrcNodes = treeView1.Nodes;
            }
            else if (moveNode.Parent == null)
            {
                SrcCategory = WordsList.MainCategory;
                SrcNodes = treeView1.Nodes;
               
            }
            else
            {
                SrcCategory = (WordsCategory)moveNode.Parent.Tag;
                SrcNodes = moveNode.Parent.Nodes;
               
            }
            if(SrcCategory == DstCategory)
            {
                if(selectNode == null)
                {
                    if (targetPoint.Y > 5) index--;
                }
                else if (moveNode.Index < selectNode.Index) index--;
            }

            IWordsItem MoveItem = (IWordsItem)moveNode.Tag;
            if (!MoveItem.ChekMove(DstCategory)) return;
            WordsList.MoveItem(index, MoveItem, SrcCategory, DstCategory);

           // treeView1.Nodes.Clear();
           // treeView1.Nodes.AddRange(WordsList.ListNodes());

            SrcNodes.Remove(moveNode);
            DstNodes.Insert(index, moveNode);



        }

        public BilderWords(WordsCategory category):base()
        {
            
        }
        public BilderWords(WordsComp item) : base()
        {

        }

      

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if (e.Node != null && !DragOn)
            {
                if (e.Node.Tag is WordsComp)
                {
                    WordsComp wordsComp = (WordsComp)e.Node.Tag;
                    control = new WordsEditCompControl(wordsComp, e.Node, imageList1);
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

            if(control != null && !DragOn)
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
                    index = 0;
                    WordsList.InsertItem(index, (WordsCategory)item, ParentCategory);
                    treeNode.ImageIndex = 0;
                    treeNode.SelectedImageIndex = 0;
                    treeNode.Text = "Новая категория";
                    break;
                case 1:
                    item = new WordsComp(new CompId("Новый ПК"));
                    WordsList.InsertItem(index, (WordsComp)item, ParentCategory);
                    treeNode.ImageIndex = 1;
                    treeNode.SelectedImageIndex = 1;
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

     

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                TreeNode tr = treeView1.GetNodeAt(e.X, e.Y);
                if (tr == null ||   !(tr.Bounds.X < e.X && (tr.Bounds.Width + tr.Bounds.X) > e.X))
                {
                    if (control != null && !DragOn)
                    {
                    control.Visible = false;
                    control.Dispose();
                    }
                    treeView1.SelectedNode = null;
                }
                   
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (control != null && !DragOn)
                {
                    control.Visible = false;
                    control.Dispose();
                }
                treeView1.SelectedNode = null;
            }
           
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
    }
}
