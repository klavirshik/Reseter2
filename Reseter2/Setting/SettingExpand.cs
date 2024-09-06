using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.Setting
{
    [Serializable]
    internal class SettingExpand
    {
        private List<string> nodePathes;
        public SettingExpand()
        {
            nodePathes = new List<string>();
        }

        public void ExpendAll(TreeNodeCollection nodes)
        {
            
            foreach (string path in nodePathes)
            {
                string[] folder = path.Split('/');
                Expand(nodes, folder, 0);
            }
            nodePathes.Clear();
        }

        private void Expand(TreeNodeCollection nodes, string[] folder, int number)
        {
            
            int i = nodes.IndexOfKey(folder[number]);
            if (i == -1) return;
            if (folder.Count() == number+1)
            {
                nodes[i].Expand();
            }
            else
            {
                Expand(nodes[i].Nodes, folder, ++number);
            }
            
        }
        
        public void SaveExpand(TreeNodeCollection nodes, string path = "")
        { 
           
           foreach(TreeNode node in nodes)
            {
                if(node.Nodes.Count > 0)
                {
                    if (node.IsExpanded)
                    {
                        nodePathes.Add(path + node.Name);
                    }
                    SaveExpand(node.Nodes, path + node.Name + "/" );
                }
            }
        }

    }
}
