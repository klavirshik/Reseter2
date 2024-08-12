using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Reseter2.Words
{
    [Serializable]
    internal class WordsComp : IWordsItem
    {
        private IComp Comp;

        public WordsComp(IComp comp)
        {
            Comp = comp;

        }
        public WordsComp(String name, String ip, String description)
        {
            IPAddress iPAddress;
            try
            {
                iPAddress = IPAddress.Parse(ip);
            }
            catch
            {
                iPAddress = null;
            }
            Comp = new CompId(name,description, iPAddress);

        }

        public void Set(String name, String ip, String description, int imgIndex)
        {
            IPAddress iPAddress;
            try
            {
                iPAddress = IPAddress.Parse(ip);
            }
            catch
            {
                iPAddress = null;
            }
            Comp.SetIP(iPAddress);
            Comp.SetName(name);
            Comp.SetDescription(description);
            Comp.SetImage(imgIndex);
        }

        public string GetName()
        {
            return Comp.GetName();
        }
        public override bool ChekMove(IWordsItem wordsItem)
        {
            return true ;
        }
        public string GetDescription()
        {
            return Comp.GetDescription();
        }
        public string GetIP()
        { 
            if(Comp.GetIP() != null)
            {
                return Comp.GetIP().ToString();
            }
            return null;
        }
       

        public override void Delete()
        {
           
            Comp = null;
        }
     
        public override List<WordsCategory> CategoryList()
        {
            return new List<WordsCategory>();
        }
        public override TreeNode NodeList() 
        { 
            TreeNode treeNode = new TreeNode(GetName());
            treeNode.Tag = this;
            treeNode.ImageIndex = Comp.GetImage();
            treeNode.SelectedImageIndex = Comp.GetImage();
            return treeNode;
        }
       
    }
}
