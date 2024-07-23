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
        public Form1()
        {
            
            InitializeComponent();
            flowLayoutPanel1.AutoScrollMinSize = new Size(0, 655) ;
            flowLayoutPanel1.VerticalScroll.Visible  = true;
            Reseter.SetForm(flowLayoutPanel1);
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
    }
}
