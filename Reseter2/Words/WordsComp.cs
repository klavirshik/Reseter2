using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.Words
{
    internal class WordsComp : IWordsItem
    {
        private IComp Comp;
        private bool cheked;

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

        public void Set(String name, String ip, String description)
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
        }

        public string GetName()
        {
            return Comp.GetName();
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
        public override void ChekChange(bool chek)
        {
            cheked = chek;
        }

        public override void Delete()
        {
           
            Comp = null;
        }
        public override List<WordsComp> ChekList()
        {

            List<WordsComp> itemsChek = new List<WordsComp>();
            if (cheked) {itemsChek.Add(this); }
            return itemsChek;
        }
        public override List<WordsCategory> CategoryList()
        {
            return new List<WordsCategory>();
        }
        public override TreeNode NodeList() 
        { 
            TreeNode treeNode = new TreeNode(GetName());
            treeNode.Tag = this;
            treeNode.ImageIndex = 2;
            return treeNode;
        }
    }
}
