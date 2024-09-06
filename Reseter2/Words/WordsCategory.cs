using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.Words
{
    [Serializable]
    internal class WordsCategory : IWordsItem
    {
        private string Name;
        private List<IWordsItem> items;

        public WordsCategory(string name)
        {
            Name = name;
            items = new List<IWordsItem>();

        }
        public WordsCategory(string name, List<IWordsItem> Items)
        {
            Name = name;
            items = Items;

        }

        public void Add(IWordsItem newitem)
        {
            items.Add(newitem);
        }
        public void Insert(int index, IWordsItem newitem)
        {
            //if (index > items.Count) index = items.Count; 
            items.Insert(index, newitem);
        }

        public void Move(int index, IWordsItem item, WordsCategory wordsdst)
        {
            items.Remove(item);
            wordsdst.Insert(index, item);
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public IWordsItem Items(int item)
        {
            return items[item];
        }

        public List<IWordsItem> Items()
        {
            return items;
        }

        public int Count()
        {
            return items.Count;
        }

        public void DeleteItem(IWordsItem wordsItem)
        {
            wordsItem.Delete();
            items.Remove(wordsItem);
        }

        public override bool ChekMove(IWordsItem wordsItem)
        {
            if(this == wordsItem) return false;
            foreach (var item in items)
            {
               if(!item.ChekMove(wordsItem)) return false;
                
            }
            return true;
        }

        public override void Delete() { 
            foreach(IWordsItem item in items) 
            { 
                item.Delete();
            }
            items.Clear();
        }

        public override List<WordsCategory> CategoryList()
        {
            List<WordsCategory> itemsCatrgory = new List<WordsCategory>();
            itemsCatrgory.Add(this);
            foreach (var item in items)
            {
                itemsCatrgory.AddRange(item.CategoryList());
            }
            return itemsCatrgory;
            
        }

        public override TreeNode NodeList()
        {
            TreeNode treeNode = new TreeNode(GetName());
            treeNode.Name = GetName();
            treeNode.Tag = this;
            treeNode.ImageIndex = 0;
            treeNode.SelectedImageIndex = 0;
            treeNode.StateImageIndex = 0;

            foreach (var item in items)
            {
                int i = treeNode.Nodes.Add(item.NodeList());
                treeNode.Nodes[i].Name += treeNode.Nodes[i].Index;
            }
            return treeNode;
        }

       
    }
}
