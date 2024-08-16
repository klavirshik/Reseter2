using Reseter2.Words;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Reseter2.Setting
{
    [Serializable]
    internal class SettingWords
    {
        public string PathBase { get; set; }
        [NonSerialized]
        private MD5 Hash = MD5.Create();
        [NonSerialized]
        private byte[] hash;
        public SettingWords()
        {
            PathBase = "base.dat";
        }

        public SettingWords(string pathBase)
        {
            PathBase = pathBase;
        }

       public void HashSumm(MemoryStream memory)
        {
             hash = Hash.ComputeHash(memory);
        }

        public bool HashCheck(MemoryStream memory)
        {
            byte[] hashSave = Hash.ComputeHash(memory);
            return !hash.SequenceEqual(hashSave);
        }
      
        
    }
}