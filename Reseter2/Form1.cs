using Reseter2.History;
using Reseter2.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2
{
    public partial class Form1 : Form
    {
        //private FormHistory formHistory;
        private bool FocusContext;
        private object selectItem;
        public Form1()
        {
            
            

            InitializeComponent();
            flowLayoutPanel1.AutoScrollMinSize = new Size(0, 683) ;
            flowLayoutPanel1.VerticalScroll.Visible  = true;
            Reseter.SetForm(flowLayoutPanel1);
            HistoryList.Update += Update_lb;
            lb_history.DataSource = HistoryList.Hitem;
            lb_history.DisplayMember = "ToStr";
            WordsCategoryControl wcc = new WordsCategoryControl();
            flow_words.Controls.Add(wcc);
            WordsItemControl wic1 = new WordsItemControl();
            wcc.Add(wic1);
            WordsItemControl wic2 = new WordsItemControl();
            wcc.Add(wic2);
            WordsItemControl wic3 = new WordsItemControl();
            wcc.Add(wic3);
            WordsItemControl wic4 = new WordsItemControl();
            wcc.Add(wic4);
            WordsItemControl wic5 = new WordsItemControl();
            wcc.Add(wic5);
            WordsItemControl wic6 = new WordsItemControl();
            wcc.Add(wic6);
            WordsItemControl wic10 = new WordsItemControl();
            wcc.Add(wic10);
            WordsItemControl wic11 = new WordsItemControl();
            wcc.Add(wic11);
       
            WordsCategoryControl wcc1 = new WordsCategoryControl();
            flow_words.Controls.Add(wcc1);
            WordsItemControl wic7 = new WordsItemControl();
            wcc1.Add(wic7);
            WordsItemControl wic8 = new WordsItemControl();
            wcc1.Add(wic8);



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
    }
}
