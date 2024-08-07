using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string GetName()
        {
            return Comp.GetName();
        }
        public override void ChekChange(bool chek)
        {
            cheked = chek;
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
    }
}
