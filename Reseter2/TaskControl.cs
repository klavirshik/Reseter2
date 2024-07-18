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
            lb_name.Text = reseterTask.GetName(); 
        }

        public void DataContrl(string ping, string timeout)
        {
            lb_ping.Text = ping;
            lb_timeout.Text = timeout;
           
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
    }
}
