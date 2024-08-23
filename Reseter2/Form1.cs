using Reseter2.History;
using Reseter2.Setting;
using Reseter2.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public delegate void saveSetting();
        public event saveSetting Save;
        public delegate void updateSetting();
        public event updateSetting UpdateSetting;
        public Form1()
        {

            //BinaryFormatter binaryFormatter = new BinaryFormatter();
            //FileStream file = new FileStream("res.dat", FileMode.OpenOrCreate);
            //try
            //{
           
            //HistoryList.Hitem = (List<HistoryItem>)binaryFormatter.Deserialize(file);
            //file.Close();
            //file.Dispose();
            
            //}
            //catch
            //{
                
            //    file.Close();
            //    file.Dispose();
            //    MessageBox.Show("Ошибка чтения конфигурационных файлов.\n Перезапустите программу.", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //}


            SGlobalSetting.LoadSetting();
            
            WordsList.MainCategory = SGlobalSetting.LoadWords();
           

            InitializeComponent();
            this.Save += settingWordsControl1.Save;
            this.Save += settingSCCMControl1.Save;
            this.Save += settingRebootControl1.Save;

            this.UpdateSetting += settingWordsControl1.UpdateSetting;
            this.UpdateSetting += settingSCCMControl1.UpdateSetting;
            this.UpdateSetting += settingRebootControl1.UpdateSetting;
            this.settingWordsControl1.UpdateTree = UpdateTree;
            // cb_comp.DropDownStyle = ComboBoxStyle.DropDown;


            checkControl1.updateCheck += CheckControl1_updateCheck;
            flowLayoutPanel1.AutoScrollMinSize = new Size(0, 658) ;
            flowLayoutPanel1.VerticalScroll.Visible  = true;
            Reseter.SetForm(flowLayoutPanel1, this);
            HistoryList.Update += Update_lb;
            lb_history.DataSource = HistoryList.Hitem;
            lb_history.DisplayMember = "ToStr";
            treeView1.PathSeparator = "/";

            treeView1.Nodes.AddRange(WordsList.ListNodes());
            SGlobalSetting.settingExpand.ExpendAll(treeView1.Nodes);
            //treeView1.SelectedNode.
            //treeView1.MouseCaptureChanged.;
            tabControl1.SelectedIndex = 1;
        }

       

        public void UpdateTree()
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.AddRange(WordsList.ListNodes());
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            Reseter.AddTask(cb_comp.Text);
            tabControl1.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Act;
            int Cls;
            Reseter.Tick(out Act,out Cls) ;
            if (Act>0)
            {
                ss_activ.Text = "Активно:" + Act;
            }
            else
            {
                ss_activ.Text = "";
            }
            if (Cls > 0)
            {
                ss_close.Text = "Завершено:" + Cls;
            }
            else
            {
                ss_close.Text = "";
            }
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
                tabControl1.SelectedIndex = 0;
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

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SGlobalSetting.settingExpand.SaveExpand(treeView1.Nodes);
            SGlobalSetting.SaveSettig();
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
                if (treeNode.Nodes[i].Checked)
                {
                    treeNode.Nodes[i].StateImageIndex = 1;
                }
                else
                {
                    treeNode.Nodes[i].StateImageIndex = 0;
                }
                treeView1_treeViewChangeCheckBox(treeNode.Nodes[i]);
            }
        }

        private int treeView1_treeViewChangeRootCheckBox(TreeNode treeNode)
        {
            if (treeNode.Nodes.Count == 0)
            {
                if(treeNode.Checked)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                bool nedoCheked = false;
                int nodeCheked = 0;
                for (int i = 0; i < treeNode.Nodes.Count; i++)
                {
                    if(treeView1_treeViewChangeRootCheckBox(treeNode.Nodes[i]) == 2) nedoCheked = true;
                    if (treeNode.Nodes[i].StateImageIndex == 1) nodeCheked++;
                    //treeNo
                    
                }
                int Cheked = 0;
                
                if (treeNode.Nodes.Count == nodeCheked)
                {
                    Cheked = 1;
                    treeNode.Checked = true;
                    treeNode.StateImageIndex = 1;
                }
                else if(nodeCheked == 0)
                {
                    Cheked = 0;
                    treeNode.Checked = false;
                    treeNode.StateImageIndex = 0;
                }
                if ((nodeCheked > 0 && treeNode.Nodes.Count > nodeCheked) || nedoCheked)
                {
                    treeNode.Checked = false;
                    treeNode.StateImageIndex = 2;
                    Cheked = 2;
                }

               
                return Cheked;
            
             }

        }

        private void treeView1_ChangePrentRootCheckBox(TreeNode treeNode)
        {
            
            if (treeNode.Parent != null)
            {       
                    //treeView1_treeViewChangeRootCheckBox(treeNode.Parent);
                    treeView1_ChangePrentRootCheckBox(treeNode.Parent);   
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left && e.Node.Tag is WordsComp)
            {
                WordsComp wordsComp = (WordsComp)e.Node.Tag;
                
                DialogResult result = MessageBox.Show("Перезагрузить ПК: " + wordsComp.NameNode(),"Создание новой задачи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    Reseter.AddTask(wordsComp.GetComp());
                    tabControl1.SelectedIndex = 0;
                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            TreeView tree = (TreeView)sender;

            Rectangle BoundsNode = new(e.Node.Bounds.X - 43, e.Node.Bounds.Y, e.Node.Bounds.Width + 43, e.Node.Bounds.Height);
            if (e.Button == MouseButtons.Right)
            {
                if (BoundsNode.Contains(e.Location) && e.Node.Tag is WordsComp)
                {
                    tree.SelectedNode = e.Node;
                    cm_words.Show(tree.PointToScreen(e.Location));
                }
                else
                {
                    tree.SelectedNode = null;
                }
              
            }
            //tree.BeginUpdate();
            Rectangle BoundsIcon = new(e.Node.Bounds.X -43, e.Node.Bounds.Y + 2, 17, 18);
            if (e.Button == MouseButtons.Left && BoundsIcon.Contains(e.Location))
            {
                e.Node.Checked = !e.Node.Checked;
                if (e.Node.Checked)
                {
                    e.Node.StateImageIndex = 1;
                }
                else
                {
                    e.Node.StateImageIndex = 0;
                }   
                treeView1_treeViewChangeCheckBox(e.Node);
                treeView1_ChangePrentRootCheckBox(e.Node);
                CheckControl1_interdmet();
            }

         
          
          //  for (int i = 0; i < tree.Nodes.Count; i++)
          //  {
          //      treeView1_treeViewChangeRootCheckBox(tree.Nodes[i]);
          //  }
          

        }



        private void treeView1_MouseCaptureChanged(object sender, EventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine(sender.ToString());
            //TreeView tree = (TreeView)sender;

            //treeView1_treeViewChangeCheckBox(tree.Nodes[0]);
            
        }

        private List<IComp> treeViewCheckOn(TreeNode node)
        {
            List<IComp> comps = new List<IComp>();
            if (node.Checked && node.Tag is WordsComp)
            {
                WordsComp comp = (WordsComp)node.Tag;
                comps.Add(comp.GetComp());
            }
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                comps.AddRange(treeViewCheckOn(node.Nodes[i]));

            }
            return comps;
        }

        private void bt_resetAll_Click(object sender, EventArgs e)
        {
            List<IComp> comps = new List<IComp>();
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                comps.AddRange(treeViewCheckOn(treeView1.Nodes[i]));
            }
            if(comps.Count == 0)
            {
                MessageBox.Show("Не выбранно ни одного ПК");
                return;
            }
            DialogResult result = MessageBox.Show("Будет перезагруженно " + comps.Count() + " компьютеров.\nПродолжить?",
                                                   "Запуск многопоточной перезагрузки.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) { 
                Reseter.AddTask(comps);
                tabControl1.SelectedIndex = 0;
            }
        }

        private void sm_SaveItem_Click(object sender, EventArgs e)
        {

            if (selectItem is HistoryItem historyItem)
            {
                BilderWords bilderWords = new BilderWords(historyItem.GetComp());
                DialogResult result = bilderWords.ShowDialog();
                if (result == DialogResult.OK)
                {
                    treeView1.Nodes.Clear();
                    treeView1.Nodes.AddRange(WordsList.ListNodes());
                }
            }
        }
        private void CheckControl1_updateCheck(bool Сhecked)
        {
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                treeView1.Nodes[i].Checked = Сhecked;
                treeView1_treeViewChangeCheckBox(treeView1.Nodes[i]);
            }
        }

        private void CheckControl1_interdmet()
        {
            int chek_inter = 0;
            
            int summ = 0;
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                int check = treeView1_treeViewChangeRootCheckBox(treeView1.Nodes[i]);
                 if (2 == check) chek_inter++;
                 if (1 == check) summ++;
            }
           
            if(treeView1.Nodes.Count == summ )
            {
                checkControl1.set_state(true);
            }
            else if(0 == summ)
            {
                checkControl1.set_state(false);
            }
             if ((summ < treeView1.Nodes.Count && summ > 0) || chek_inter > 0)
            {
                checkControl1.set_intedmet();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Save();
            SGlobalSetting.settingExpand.SaveExpand(treeView1.Nodes);
            SGlobalSetting.SaveSettig();
            SGlobalSetting.LoadSetting();
            WordsList.MainCategory = SGlobalSetting.LoadWords();
            treeView1.Nodes.Clear();
            treeView1.Nodes.AddRange(WordsList.ListNodes());
            SGlobalSetting.settingExpand.ExpendAll(treeView1.Nodes);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 3) 
            {
                UpdateSetting();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reseter.ClearCanceled();
        }

        private void WordsReboot_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode.Tag is WordsComp)
            {
                WordsComp wordsComp = (WordsComp)treeView1.SelectedNode.Tag;

                DialogResult result = MessageBox.Show("Перезагрузить ПК: " + wordsComp.NameNode(), "Создание новой задачи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Reseter.AddTask(wordsComp.GetComp());
                    tabControl1.SelectedIndex = 0;
                }
            }
           
        }
    }
}

