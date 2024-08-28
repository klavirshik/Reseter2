using Reseter2.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.Seacher
{
    internal class SeahcLocal : ISeaherMetod
    {
        internal delegate void ResultUpdate(List<string> Item);
        private ResultUpdate Update;
        List<IComp> comps = new List<IComp>();
        public void Change(ResultUpdate sender, string seach)
        {
            Update = sender;
            if (seach.Length > 2)
            {
                
                Update(ResultSeach(seach));
            } 
            else
            {
                List<string> result = new List<string>();
                result.Add("Введите запрос");
                Update(result);
            }
            
        }
        public List<string> ResultSeach(string seach)
        {
            int i = 0;
            comps.Clear();
            List<string> result = new List<string>();
            foreach(HistoryItem item in HistoryList.Hitem)
            {
                if (item.NameNode().Contains(seach))
                {
                    result.Add(item.NameNode());
                    comps.Add(item.GetComp());
                    ++i;
                    if (i>6) return result;
                }
               
            }
            if(i == 0) result.Add("Ничего не найдено");
            return result;
        }
        public IComp Result(int index)
        {
            return comps[index];
        }
    }
}
