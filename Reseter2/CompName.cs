using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2
{
    [Serializable]
    internal class CompId : IComp
    {
        private int imgIndex=1;
        private string Name { get; set; }
        private string Description { get; set; }
        private IPAddress Ip { get; set; }
        private string netName;

        public CompId(string netname)
        {
            this.netName = netname;
            //this.Name = netname;
            
        }

        



        public CompId(IPAddress ip)
        {
            this.Ip = ip;
        }
        public CompId(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }



        public CompId(string name, string description, IPAddress ip)
        {
            this.Name = name;
            this.Description = description;
            this.Ip = ip;
        }


        public string GetName()
        {
            return Name;
        }

        public string GetNetNameStr()
        {
            if (netName == null) return GetIPStr();
            return netName;
        }
        public string GetNetName()
        {
            return netName;
        }
        public IPAddress GetIP()
        {
            return Ip;
        }

        public string GetIPStr()
        {
            if (Ip != null) return Ip.ToString();
            return null;
        }
        public int GetImage()
        {
            return imgIndex;
        }

        public void SetIP(IPAddress ip)
        {
            Ip = ip;
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public void SetNetName(string netname)
        {
            netName = netname;
        }

        public void SetImage(int image)
        {
            imgIndex = image;
        }
        public void SetDescription(string description)
        {
            Description = description;
        }

        public string GetResetName()
        {
            if (netName != null) return netName;
            return GetIPStr();
        }

    public string GetDescription()
        {
            return Description;
        }
       
        

    }
}
