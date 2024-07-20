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

namespace Reseter2
{
    [DefaultEvent(nameof(TaskControl))]
    partial class TaskControl : UserControl
    {
        ReseterTask reseterTask;
        public TaskControl()
        {
            reseterTask = null;
            InitializeComponent();
        }

        public void Intit(ReseterTask res)
        {
            reseterTask = res;
            if (reseterTask.GetName() != null) lb_name.Text = reseterTask.GetName();
            if (reseterTask.Comp.GetIP() != null) lb_ip.Text = reseterTask.Comp.GetIP().ToString();
        }

        public void DataContrl(string ping, string timeout, IPAddress ip, TimeSpan time)
        {
            lb_ping.Text = ping;
            lb_timeout.Text = timeout;
            if(ip != null)lb_ip.Text = ip.ToString();  
            lb_time.Text = time.ToString(@"mm\:ss");
           
        }
        public void TimeContrl(TimeSpan time)
        {
            lb_time.Text = time.ToString(@"mm\:ss");

        }
        public void SetNameStage(string nameStage)
        {
            lb_stage.Text = nameStage;
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
    }
}
