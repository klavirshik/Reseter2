using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.Words
{
    internal partial class BilderWords : Form
    {
        public BilderWords()
        {
            InitializeComponent();
            
        }

        public BilderWords(WordsCategory category):base()
        {
            
        }
        public BilderWords(WordsComp item) : base()
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_category.Checked)
            {

            }
            else
            {

            }
         }
    }
}
