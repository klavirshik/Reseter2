using Reseter2.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reseter2
{
    [DefaultEvent(nameof(TaskControl))]
    partial class TaskControl : UserControl
    {
        ReseterTask reseterTask;
        public delegate void DUpdateTree();
        public DUpdateTree UpdateTree;
        public TaskControl()
        {
            reseterTask = null;
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
            
        }

        public void Intit(ReseterTask res)
        {
            reseterTask = res;
            if (reseterTask.GetName() != null) lb_name.Text = reseterTask.GetName();
            if (reseterTask.Comp.GetNetNameStr() != null)
            {
                lb_ip.Text = reseterTask.Comp.GetNetNameStr();
                if (reseterTask.Comp.GetIP() != null && reseterTask.Comp.GetNetName() != null) lb_ip.Text = lb_ip.Text+"(" +reseterTask.Comp.GetIP().ToString()+")";
            }
           
           
        }

        public void DataContrl(string ping, string timeout, IPAddress ip, string netname, TimeSpan time)
        {
            lb_ping.Text = ping;
            lb_timeout.Text = timeout;
            lb_ip.Text = reseterTask.Comp.GetNetNameStr();

            if (netname != null)
            {
                lb_ip.Text = netname;
                if (ip != null && netname != null) lb_ip.Text = lb_ip.Text + "(" + ip.ToString() + ")";
            }
            else
            {
                if (ip != null) lb_ip.Text = ip.ToString();
            }
            
            
           
             
            lb_time.Text = time.ToString(@"mm\:ss");
           
        }
        public void TimeContrl(TimeSpan time)
        {
            lb_time.Text = time.ToString(@"mm\:ss");

        }
        public void SetNameStage(string nameStage, int indexImg, bool pauseOn)
        {
            lb_stage.Text = nameStage;
            pictureBox1.Image = imageList1.Images[indexImg];
            button3.Enabled=pauseOn;
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reseter.Clear(reseterTask, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reseterTask.RebootStop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reseterTask.RebootReturn();
        }

        private void cm_taskSave_Click(object sender, EventArgs e)
        {
           BilderWords bilderWords = new BilderWords(reseterTask.Comp);
           DialogResult result = bilderWords.ShowDialog();
            if (result == DialogResult.OK)
            {
               UpdateTree();
            }
        }
    }
}
