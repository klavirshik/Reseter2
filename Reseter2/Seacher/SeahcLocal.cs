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
        internal delegate void ResultUpdate(List<string> Item, bool eneble);
        private ResultUpdate Update;
        private List<IComp> comps = new List<IComp>();
        private bool enable;
        public void Change(ResultUpdate sender, string seach)
        {
            Update = sender;
            if (seach.Length > 2)
            {
                
                Update(ResultSeach(seach), enable);
            } 
            else
            {
                List<string> result = new List<string>();
                result.Add("Введите запрос");
                Update(result,false);
            }
            
        }
        public List<string> ResultSeach(string seach)
        {
            int i = 0;
            comps.Clear();
            List<string> result = new List<string>();
            foreach(HistoryItem item in HistoryList.Hitem)
            {
                if (item.NameNode().ToUpper().Contains(seach.ToUpper()))
                {
                    int y = 0;
                    foreach(string itemOk in result)
                    {
                        if (itemOk.ToUpper() == item.NameNode().ToUpper()) ++y;
                    }
                    if(y == 0)
                    {
                        result.Add(item.NameNode());
                        comps.Add(item.GetComp());
                        ++i;
                        enable = true;
                        if (i>6) return result;
                    }
                  
                }
               
            }
            if (i == 0)
            {   
                enable = false;
                result.Add("Ничего не найдено");
            }
            return result;
        }
        public IComp Result(int index)
        {
            return comps[index];
        }
        public void Activate() { }
        public void Deactivate() { }
    }
}
