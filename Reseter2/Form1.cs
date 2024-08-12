using Reseter2.History;
using Reseter2.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2
{
    public partial class Form1 : Form
    {
        //private FormHistory formHistory;
        //System.Windows.Forms.CheckBox
        
        private bool FocusContext;
        private object selectItem;
        public Form1()
        {

            try
            {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = new FileStream("res.dat", FileMode.OpenOrCreate);
            HistoryList.Hitem = (List<HistoryItem>)binaryFormatter.Deserialize(file);
            file.Dispose();
            file.Close();

            binaryFormatter = new BinaryFormatter();
             file = new FileStream("base.dat", FileMode.OpenOrCreate);
            WordsList.MainCategory = (WordsCategory)binaryFormatter.Deserialize(file);
            file.Dispose();
            file.Close();
            }
            catch
            {

            }
            

            InitializeComponent();
            flowLayoutPanel1.AutoScrollMinSize = new Size(0, 683) ;
            flowLayoutPanel1.VerticalScroll.Visible  = true;
            Reseter.SetForm(flowLayoutPanel1);
            HistoryList.Update += Update_lb;
            lb_history.DataSource = HistoryList.Hitem;
            lb_history.DisplayMember = "ToStr";

            treeView1.Nodes.AddRange(WordsList.ListNodes());
            //treeView1.Check
           //treeView1.MouseCaptureChanged.;
            tabControl1.SelectedIndex = 1;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            Reseter.AddTask(tb_comp.Text) ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Reseter.Tick();
        }
        public void Update_lb()
        {
            lb_history.DataSource = null;
            lb_history.DataSource = HistoryList.Hitem;
            lb_history.DisplayMember = "ToStr";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoryList.Clear();
            lb_history.DataSource = null;
            lb_history.DataSource = HistoryList.Hitem;
            lb_history.DisplayMember = "ToStr";
        }

        private void RebootItem_Click(object sender, EventArgs e)
        {

        }

        private void sm_RebootItem_Click(object sender, EventArgs e)
        {
            if(selectItem is HistoryItem historyItem)
            {
                Reseter.AddTask(historyItem.GetComp());
            }
        }

        private void lb_history_MouseMove(object sender, MouseEventArgs e)
        {
           lb_history.SelectedIndex = lb_history.IndexFromPoint(e.Location);
        }

        private void lb_history_MouseLeave(object sender, EventArgs e)
        {

            if(!FocusContext)
            {
                lb_history.SelectedIndex = -1;
            }
            
        }

        private void cm_history_Opening(object sender, CancelEventArgs e)
        {
            selectItem = lb_history.SelectedItem;
            FocusContext = true;
        }

        private void lb_history_MouseDown(object sender, MouseEventArgs e)
        {
            
           // lb_history.SelectedIndex = lb_history.IndexFromPoint(e.Location);
        }

        private void cm_history_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
           // selectItem = null;
            FocusContext = false;
        }

        private void mi_newitem_Click(object sender, EventArgs e)
        {
            BilderWords bilderWords = new BilderWords();
            bilderWords.ShowDialog();
        }

        private void bt_wordsBilder_Click(object sender, EventArgs e)
        {
            BilderWords bilderWords = new BilderWords();
            bilderWords.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = new FileStream("res.dat", FileMode.OpenOrCreate);
            binaryFormatter.Serialize(file, HistoryList.Hitem);
            file.Close();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {

          
            //   treeView1_treeViewChangeCheckBox(e.Node);

        }
        
        private void treeView1_treeViewChangeCheckBox(TreeNode treeNode)
        {
            for (int i = 0; i < treeNode.Nodes.Count; i++)
            {
                treeNode.Nodes[i].Checked = treeNode.Checked;
                treeView1_treeViewChangeCheckBox(treeNode.Nodes[i]);
            }
        }

        private bool treeView1_treeViewChangeRootCheckBox(TreeNode treeNode)
        {
            if (treeNode.Nodes.Count == 0)
            {
                return treeNode.Checked;
            }
            else
            {
                int nodeCheked = 0;
                for (int i = 0; i < treeNode.Nodes.Count; i++)
                {
                    treeView1_treeViewChangeRootCheckBox(treeNode.Nodes[i]);
                    if (treeNode.Nodes[i].Checked) nodeCheked++;

                }
                bool Cheked = false;
                if (treeNode.Nodes.Count == nodeCheked)
                {
                    Cheked = true;
                    treeNode.Checked = Cheked;
                }
                else if (nodeCheked != 0)
                {
                     treeNode.StateImageIndex = 2;
                }


                
                return Cheked;
            
             }

        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("dfsdf");
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            if (e.Node.Tag is WordsComp)
            {
                WordsComp wordsComp = (WordsComp)e.Node.Tag;
                
                MessageBox.Show("Перезагрузить ПК: " + wordsComp.GetName());

            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("klic");
            treeView1_treeViewChangeCheckBox(e.Node);
            TreeView tree = (TreeView)sender;
            for (int i = 0; i < tree.Nodes.Count; i++)
            {
                treeView1_treeViewChangeRootCheckBox(tree.Nodes[i]);
            }

            
        }

        private void treeView1_MouseCaptureChanged(object sender, EventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine(sender.ToString());
            //TreeView tree = (TreeView)sender;

            //treeView1_treeViewChangeCheckBox(tree.Nodes[0]);
            
        }
    }
}
