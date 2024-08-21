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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reseter2.Setting
{
  
    partial class SettingWordsControl : UserControl
    {

        public NewTreeView treeView;
        public SettingWordsControl()
        {
            InitializeComponent();
            if(SGlobalSetting.settingWords != null)
            {
                path.Text = SGlobalSetting.settingWords.PathBase;
            }
        }

        private void bt_wordsBilder_Click(object sender, EventArgs e)
        {
            BilderWords bilderWords = new BilderWords();
            DialogResult result = bilderWords.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (treeView != null)
                {
                treeView.Nodes.Clear();
                treeView.Nodes.AddRange(WordsList.ListNodes());
                } 
            }
        }

        private void bt_path_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName != null)
            {
                path.Text = openFileDialog1.FileName;
            }
        }

        public void Save()
        {
            if(SGlobalSetting.settingWords.PathBase != path.Text)
            {
                SGlobalSetting.settingWords.PathBase = path.Text;
            }
            
        }
    }
}
