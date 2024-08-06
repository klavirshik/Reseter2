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

        public override string GetName()
        {
            return Name;
        }
        public override bool Cheked()
        {
            return cheked;
        }
    }
}
