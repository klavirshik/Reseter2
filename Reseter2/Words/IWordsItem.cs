using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.Words
{
    internal abstract class IWordsItem
    { 
       
        public abstract List<WordsComp> ChekList();
        public abstract List<WordsCategory> CategoryList();

        public abstract void ChekChange(bool chek);
        public abstract void Delete();
        public abstract TreeNode NodeList();
        public abstract bool ChekMove(IWordsItem wordsItem);
       

        

    }
}
