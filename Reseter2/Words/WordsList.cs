using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.Words
{
    [Serializable]
    static class WordsList
    {
        public static WordsCategory MainCategory = new WordsCategory("Main");
        public static void AddItem(IWordsItem item, WordsCategory wordsCategory)
        {
            wordsCategory.Add(item);
        }
        public static void InsertItem(int index,IWordsItem item, WordsCategory wordsCategory)
        {
            wordsCategory.Insert(index, item);
        }

        public static void MoveItem(int index, IWordsItem item, WordsCategory SrcCategory, WordsCategory DstCategory)
        {
            SrcCategory.Move(index, item, DstCategory);
        }

        public static TreeNode[] ListNodes()
        {
            TreeNode[] treeNodes = new TreeNode[MainCategory.Count()];
            for(int i = 0; i < MainCategory.Count(); i++)
            {
                treeNodes[i] = MainCategory.Items(i).NodeList();
            }           

            return treeNodes;
        }

        public static TreeNode[] ListNodes(WordsCategory ChangeCategory)
        {
            TreeNode[] treeNodes = new TreeNode[ChangeCategory.Count()];
            for (int i = 0; i < ChangeCategory.Count(); i++)
            {
                treeNodes[i] = ChangeCategory.Items(i).NodeList();
            }

            return treeNodes;
        }
    }
}
