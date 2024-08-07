using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        public void Add(IWordsItem newitem)
        {
            items.Add(newitem);
        }
        
        public string GetName()
        {
            return Name;
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
    }
}
