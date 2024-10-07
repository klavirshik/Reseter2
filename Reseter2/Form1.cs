using Reseter2.History;
using Reseter2.Seacher;
using Reseter2.Setting;
using Reseter2.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private bool unSave;
        private bool FocusContext;
        private object selectItem;
        public delegate void saveSetting();
        public event saveSetting Save;
        public delegate void updateSetting();
        public event updateSetting UpdateSetting;
        private ListBox ListComp;
        private IComp CompSelected = null;
        private int PreSelected = -1;
        private bool StopRefreshSeacher = false;
        public Form1()
        {

            
            SGlobalSetting.LoadSetting();

            WordsList.MainCategory = SGlobalSetting.LoadWords();
            ListComp = new ListBox();
            this.Controls.Add(ListComp);
            ListComp.GotFocus += tb_comp_Enter;
            ListComp.DrawMode = DrawMode.OwnerDrawFixed;
            ListComp.DrawItem += ListComp_DrawItem;
            ListComp.KeyDown += tb_comp_KeyDown;
            
            //ListComp.SetSelected(1,true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            this.Save += settingWordsControl1.Save;
            this.Save += settingSCCMControl1.Save;
            this.Save += settingRebootControl1.Save;

            this.UpdateSetting += settingWordsControl1.UpdateSetting;
            this.UpdateSetting += settingSCCMControl1.UpdateSetting;
            this.UpdateSetting += settingRebootControl1.UpdateSetting;
            this.settingWordsControl1.UpdateTree = UpdateTree;


            ListComp.SelectionMode = SelectionMode.One;
            ListComp.Location = new Point(tb_comp.Location.X, tb_comp.Location.Y + tb_comp.Height);
            ListComp.Width = tb_comp.Width;
            ListComp.Visible = false;
            ListComp.ItemHeight = 14;
            ListComp.Height = ListComp.ItemHeight * 2;
            ListComp.Items.Add("Введите запрос");
            ListComp.SelectedIndexChanged += ListComp_ChangeIndex;
            ListComp.Enabled = false;
            
            //tb_comp.Controls.Add(ListComp);


            checkControl1.updateCheck += CheckControl1_updateCheck;
            flowLayoutPanel1.AutoScrollMinSize = new Size(0, 658);
            flowLayoutPanel1.VerticalScroll.Visible = true;
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
            checkControl1.set_state(false);
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            if (CompSelected == null)
            {
                if (tb_comp.Text.Length > 0)
                {
                    DialogResult result = MessageBox.Show("Перезагрузить ПК: " + tb_comp.Text.Trim(), "Создание новой задачи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Reseter.AddTask(tb_comp.Text.Trim());
                        tabControl1.SelectedIndex = 0;
                        StopRefreshSeacher = true;
                        tb_comp.Text = "";
                        ListComp.SelectedIndex = -1;
                        ListComp.Items.Clear();
                        ListComp.Items.Add("Введите запрос");
                        ListComp.Enabled = false;
                        ListComp.ItemHeight = 14;
                        ListComp.Height = ListComp.ItemHeight * 2;
                        StopRefreshSeacher = false;
                        ListComp.Visible = false;
                        tabControl1.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Введите имя ПК","Ошибка перезагрузки",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Перезагрузить ПК: " + CompSelected.GetNetNameStr(), "Создание новой задачи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Reseter.AddTask(CompSelected);
                    tabControl1.SelectedIndex = 0;
                    StopRefreshSeacher = true;
                    tb_comp.Text = "";
                    ListComp.SelectedIndex = -1;
                    ListComp.Items.Clear();
                    ListComp.Items.Add("Введите запрос");
                    ListComp.ItemHeight = 14;
                    ListComp.Enabled = false;
                    ListComp.Height = ListComp.ItemHeight * 2;
                    StopRefreshSeacher = false;
                    ListComp.Visible = false;
                    tabControl1.SelectedIndex = 0;
                }   
            }       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Act;
            int Cls;
            Reseter.Tick(out Act, out Cls);
            if (Act > 0)
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



        private void sm_RebootItem_Click(object sender, EventArgs e)
        {
            if (selectItem is HistoryItem historyItem)
            {
                DialogResult result = MessageBox.Show("Перезагрузить ПК: " + historyItem.GetComp().GetNetNameStr(), "Создание новой задачи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Reseter.AddTask(historyItem.GetComp());
                    tabControl1.SelectedIndex = 0;

                }
                
            }
        }

        private void lb_history_MouseMove(object sender, MouseEventArgs e)
        {
            lb_history.SelectedIndex = lb_history.IndexFromPoint(e.Location);
        }

        private void lb_history_MouseLeave(object sender, EventArgs e)
        {

            if (!FocusContext)
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
                if (treeNode.Checked)
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
                    if (treeView1_treeViewChangeRootCheckBox(treeNode.Nodes[i]) == 2) nedoCheked = true;
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
                else if (nodeCheked == 0)
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


        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Button == MouseButtons.Left && e.Node.Tag is WordsComp)
            {
                WordsComp wordsComp = (WordsComp)e.Node.Tag;

                DialogResult result = MessageBox.Show("Перезагрузить ПК: " + wordsComp.NameNode(), "Создание новой задачи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
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
            Rectangle BoundsIcon = new(e.Node.Bounds.X - 43, e.Node.Bounds.Y + 2, 17, 18);
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
            if (comps.Count == 0)
            {
                MessageBox.Show("Не выбранно ни одного ПК");
                return;
            }
            DialogResult result = MessageBox.Show("Будет перезагруженно " + comps.Count() + " компьютеров.\nПродолжить?",
                                                   "Запуск многопоточной перезагрузки.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Reseter.AddTask(comps);
                checkControl1.set_state(false);
                CheckControl1_updateCheck(false);
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
                    UpdateTree();
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

            if (treeView1.Nodes.Count == summ)
            {
                checkControl1.set_state(true);
            }
            else if (0 == summ)
            {
                checkControl1.set_state(false);
            }
            if ((summ < treeView1.Nodes.Count && summ > 0) || chek_inter > 0)
            {
                checkControl1.set_intedmet();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Save();
            SGlobalSetting.settingExpand.SaveExpand(treeView1.Nodes);
            SGlobalSetting.SaveSettig();
            SGlobalSetting.LoadSetting();
            WordsList.MainCategory = SGlobalSetting.LoadWords();
            UpdateTree();
            SGlobalSetting.settingExpand.ExpendAll(treeView1.Nodes);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 3)
            {
                if (!unSave)
                {
                    unSave = true;
                    UpdateSetting();
                }

            }
            else
            {
                if (unSave && (settingRebootControl1.edited() ||
                    settingSCCMControl1.edited() ||
                    settingWordsControl1.edited()))
                {
                    DialogResult result = MessageBox.Show("Изменения не сохраненны. Продолжить?", "Изменения не сохраненны.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.Cancel:
                            tabControl1.SelectedIndex = 3;
                            break;
                        case DialogResult.OK:
                            unSave = false;
                            break;
                    }
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reseter.ClearCanceled();
        }

        private void WordsReboot_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Tag is WordsComp)
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

        private void cb_comp_TextUpdate(object sender, EventArgs e)
        {

            //Cursor.Current = Cursors.Default;
            if (sender is TextBox && !StopRefreshSeacher)
            {
                TextBox textBox = (TextBox)sender;
                SSeaher.seaherMetod.Change(cb_comp_ResultUpdate, textBox.Text);
                CompSelected = null;
                ListComp.Visible = true;
            }

        }
        public void cb_comp_ResultUpdate(List<string> Items, bool enable, int itemHeight)
        {
            PreSelected = -1;
            ListComp.ItemHeight = itemHeight;
            ListComp.Height = ListComp.ItemHeight * (Items.Count+1) ;
            ListComp.Items.Clear();
            ListComp.Items.AddRange(Items.ToArray());
            ListComp.Enabled = enable;
           
            // ListComp.Visible = true;


        }

        private void tb_comp_Enter(object sender, EventArgs e)
        {
           // ListComp.Visible = true;
        }

        private void tb_comp_MouseClick(object sender, MouseEventArgs e)
        {
            ListComp.Visible = true;
        }


        private void ListComp_ChangeIndex(object sender, EventArgs e)
        {
            if(ListComp.SelectedIndex > -1)
            { 
                StopRefreshSeacher = true;
                CompSelected = SSeaher.seaherMetod.Result(ListComp.SelectedIndex);
                tb_comp.Text = SSeaher.seaherMetod.ResultString(ListComp.SelectedIndex);
                PreSelected = ListComp.SelectedIndex;
                ListComp.Refresh();
                StopRefreshSeacher = false;
            }
           
        }


        private void ListComp_DrawItem(object sender, DrawItemEventArgs e)
        {
      
            if (e.Index != -1) {
                Point BoundNew = new(e.Bounds.Location.X, e.Bounds.Y + 1);
                if (e.Index == PreSelected)
                {
                    e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                }
                   
                //if(MouseButtons == MouseButtons.Left  && e.Bounds.Contains(ListComp.PointToClient(MousePosition)))
                if(e.Index == ListComp.SelectedIndex)
                {
                    e.Graphics.FillRectangle(Brushes.DodgerBlue, e.Bounds);
                    e.Graphics.DrawString(ListComp.Items[e.Index].ToString(), e.Font, Brushes.White, BoundNew);
                }
                else
                {
                    e.Graphics.DrawString(ListComp.Items[e.Index].ToString(), e.Font, Brushes.Black, BoundNew);
                }


            }
           
        }

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == 0x210 && m.WParam.ToInt32() == 513) || m.Msg == 0x201)
            {
                Point clickPoint = this.PointToClient(Cursor.Position);
                if (!ListComp.Bounds.Contains(clickPoint))
                {
                    ListComp.Visible = false;
                }
               // System.Console.WriteLine("clickers");
                
            }
            base.WndProc(ref m);
        }

        private void tb_comp_KeyDown(object sender, KeyEventArgs e)
        {
          
           switch (e.KeyValue)
            {
                case 40:
                    if(PreSelected < ListComp.Items.Count - 1)
                    {
                        ++PreSelected;
                    } 
                    e.SuppressKeyPress = true;
                    ListComp.Refresh();
                    break;
                case 38:
                    if (PreSelected >  0)
                    {
                        --PreSelected;
                    }
                   
                    e.SuppressKeyPress = true;
                    ListComp.Refresh();
                    break;
                case 13:
                    if(PreSelected == ListComp.SelectedIndex)
                    {
                        bt_reset_Click(null, null);
                        break;
                    }
                    else if (PreSelected >= 0)
                    {
                        ListComp.SelectedIndex = PreSelected;
                        e.SuppressKeyPress = true;
                        StopRefreshSeacher = true;
                        CompSelected = SSeaher.seaherMetod.Result(ListComp.SelectedIndex);
                        tb_comp.Text = SSeaher.seaherMetod.ResultString(ListComp.SelectedIndex);
                        StopRefreshSeacher = false;
                        ListComp.Refresh();

                    }
                  break;  
            }
                
               
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WordsCopy_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Tag is WordsComp)
            {
                WordsComp wordsComp = (WordsComp)treeView1.SelectedNode.Tag;

                Clipboard.SetText(wordsComp.GetNetName());
            }
        }
    }
}

