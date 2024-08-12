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
        private bool FocusContext;
        private object selectItem;
        public Form1()
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

            InitializeComponent();
            flowLayoutPanel1.AutoScrollMinSize = new Size(0, 683) ;
            flowLayoutPanel1.VerticalScroll.Visible  = true;
            Reseter.SetForm(flowLayoutPanel1);
            HistoryList.Update += Update_lb;
            lb_history.DataSource = HistoryList.Hitem;
            lb_history.DisplayMember = "ToStr";

            treeView1.Nodes.AddRange(WordsList.ListNodes());

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

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
          
            Font font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            if (e.Node.IsVisible)
            {
                if (e.Node.Tag is WordsCategory)
                {
                    font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), e.Bounds.X, e.Bounds.Y, e.Node.TreeView.Width, e.Bounds.Height);
                    e.Graphics.DrawString(e.Node.Text, font, new SolidBrush(Color.Black), new PointF(e.Bounds.X + 33, e.Bounds.Y));
                }
                else
                {
                    e.Graphics.DrawString(((WordsComp)e.Node.Tag).GetName(), font, new SolidBrush(Color.Black), new PointF(e.Bounds.X + 3, e.Bounds.Y));
                    e.Graphics.DrawString(((WordsComp)e.Node.Tag).GetIP(), font, new SolidBrush(Color.Black), new PointF(e.Bounds.X + 103, e.Bounds.Y));
                    e.Graphics.DrawString(((WordsComp)e.Node.Tag).GetDescription(), font, new SolidBrush(Color.Black), new PointF(e.Bounds.X + 3, e.Bounds.Y+12));

                }
                    
                
            }
            //e.Bounds
            
        }
    }
}
