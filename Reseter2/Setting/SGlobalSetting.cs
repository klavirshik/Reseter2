using Reseter2.Words;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Reseter2.Setting
{
    [Serializable]
    internal static class SGlobalSetting
    {
        public static SettingHistory settingHistory
        public static SettingWords settingWords = new SettingWords(); 

        public static void LoadSetting()
        {

        }

        public static bool Load(string path)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = null;
            try
            {
                file = new FileStream(path, FileMode.Open);
                WordsList.MainCategory = (WordsCategory)binaryFormatter.Deserialize(file);
                file.Close();
                file.Dispose();
                return true;
            }
            catch
            {
                return false;
            }

        }

        private static object Clone(object input)
        {
            object output;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream Memory = new MemoryStream();
            binaryFormatter.Serialize(Memory, input);
            Memory.Position = 0;
            if (input is WordsCategory) settingWords.HashSumm(Memory);
            Memory.Position = 0;
            output = binaryFormatter.Deserialize(Memory);
            Memory.Dispose();
            Memory.Close();

            return output;
        }

        public static WordsCategory Clone(WordsCategory input)
        {
            return (WordsCategory)Clone((object)input);
        }

        public static IComp Clone(IComp input)
        {
            return (IComp)Clone((object)input);
        }

        public static void Save()
        {

        }


    }
}
