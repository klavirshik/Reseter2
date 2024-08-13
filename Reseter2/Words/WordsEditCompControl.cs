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

    [DefaultEvent(nameof(WordsEditCompControl))]
    internal partial class WordsEditCompControl : UserControl
    {
        private WordsComp wordsComp;
        private TreeNode treeNode;
        private ImageList imageList;
        public WordsEditCompControl()
        {
            InitializeComponent();
        }
        public WordsEditCompControl(WordsComp wordscomp, TreeNode treenode, ImageList imagelist)
        {
            InitializeComponent();
            imageList = imagelist;
            comboBox1.DataSource = imageList.Images;
            lb_name.Text = wordscomp.GetName();
            lb_ip.Text = wordscomp.GetIP();
            lb_description.Text = wordscomp.GetDescription();
            tb_netName.Text = wordscomp.GetNetName();
            wordsComp = wordscomp;
            treeNode = treenode;
            comboBox1.SelectedIndex = treeNode.ImageIndex;
        }
        public void Save()  
        {
           
        }

        private void WordsEditCompControl_VisibleChanged(object sender, EventArgs e)
        {
            wordsComp.Set(lb_name.Text.Length > 0 ? lb_name.Text : null, 
                          lb_ip.Text.Length > 0 ? lb_ip.Text : null,
                          lb_description.Text.Length > 0 ? lb_description.Text : null,
                          comboBox1.SelectedIndex,
                          tb_netName.Text.Length > 0 ? tb_netName.Text : null);
            treeNode.Text = wordsComp.NameNode();
            treeNode.ImageIndex = comboBox1.SelectedIndex;
            treeNode.SelectedImageIndex = comboBox1.SelectedIndex;
           
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if(e.Index != -1)
            {
                e.Graphics.DrawImage(imageList.Images[e.Index],e.Bounds.Left, e.Bounds.Top, imageList.Images[e.Index].Width, imageList.Images[e.Index].Height);
            }
            
        }
    }
}
