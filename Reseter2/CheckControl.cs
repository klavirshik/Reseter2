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
    
    [DefaultEvent(nameof(CheckControl))]
    
    partial class CheckControl : UserControl
    {
        
        public bool Checked = false;
        // public ImageList imageList;
        public delegate void UpdateCheck(bool check);
        public event UpdateCheck updateCheck;
            
        public CheckControl():base()
        {
            // imageList = imagelist;
            if (!this.DesignMode)
            {
                InitializeComponent();
                pictureBox1.Image = imageList2.Images[0];
            }
            
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
            if (Checked)
            {
                pictureBox1.Image = imageList2.Images[1];
            }
            else
            {
                pictureBox1.Image = imageList2.Images[0];
            }
            updateCheck(Checked);
        }

        public void set_intedmet()
        {
            pictureBox1.Image = imageList2.Images[2];
        }
        public void set_state(bool checkeds)
        {
            Checked = checkeds;
            if (Checked)
            {
                pictureBox1.Image = imageList2.Images[1];
            }
            else
            {
                pictureBox1.Image = imageList2.Images[0];
            }
           // updateCheck(Checked);
        }
    }
}
