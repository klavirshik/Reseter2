using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.Words
{
    internal class WordsCategory : IWordsItem
    {
        private string Name;
        private bool cheked;
        private List<IWordsItem> items;

        public WordsCategory(string name)
        {
            Name = name;
            items = new List<IWordsItem>();

        }

        public void Add(IWordsItem newitem)
        {
            items.Add(newitem);
        }
        public void Insert(int index, IWordsItem newitem)
        {
            items.Insert(index, newitem);
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

        public int Count()
        {
            return items.Count;
        }

        public void DeleteItem(IWordsItem wordsItem)
        {
            wordsItem.Delete();
            items.Remove(wordsItem);
        }

        public override void Delete() { 
            foreach(IWordsItem item in items) 
            { 
                item.Delete();
            }
            items.Clear();
        }
        public override void ChekChange(bool chek)
        {
           cheked = chek;
           foreach(var item in items)
            {
                item.ChekChange(chek);
            }
        }       
        public override List<WordsComp> ChekList()
        {
            List<WordsComp> itemsChek = new List<WordsComp>();
            foreach (var item in items)
            {
                itemsChek.AddRange(item.ChekList());
            }
            return itemsChek;
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
            treeNode.Tag = this;
            treeNode.ImageIndex = 1;
           
            foreach (var item in items)
            {
                treeNode.Nodes.Add(item.NodeList());
            }
            return treeNode;
        }
    }
}
