using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    internal class CompId : IComp
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private string Ip { get; set; }

        public CompId(string name)
        {
            this.Name = name; 
        }
        public CompId(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public CompId(string name, string description, string ip)
        {
            this.Name = name;
            this.Description = description;
            this.Ip = ip;
        }


        public string GetName()
        {
            return Name;
        }

    public string GetDescription()
        {
            return Description;
        }
         

    }
}
