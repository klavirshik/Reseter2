using Reseter2.History;
using Reseter2.Words;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2.Setting
{
    [Serializable]
    internal static class SGlobalSetting 
    {
       
        public static SettingWords settingWords = new SettingWords();

       //public static void LoadSetting()
       // {

            
       // }



        public static void LoadSetting()
        {
            object output = Load("res.dat");
            if (!(output is SSetting)) return;
            SSetting setting = (SSetting)output;
            settingWords = setting .settingWords;
            HistoryList.Hitem = setting.historyItems;

           // return output;
        }

        public static WordsCategory LoadWords() 
        {
            WordsCategory output = (WordsCategory)Load(settingWords.PathBase);
            if (output == null)
            {
               output = new WordsCategory("Main");
            }
            return output;
        }
        private static object Load(string path)
        {
            object obj = null;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = null;
            try
            {
                file = new FileStream(path, FileMode.Open);
                obj = binaryFormatter.Deserialize(file);
                file.Close();
                file.Dispose();
                return obj;
            }
            catch
            {
                return null;
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

        public static bool SaveClose(WordsCategory output, DialogResult ok = DialogResult.No)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream Memory = new MemoryStream();
            binaryFormatter.Serialize(Memory, output);
            FileStream file = null;
            Memory.Position = 0;
            if (settingWords.HashCheck(Memory) )
            {
                if (ok == DialogResult.OK)
                {
                    Memory.Close();
                    Memory.Dispose();
                    return Save(output);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Сохранить внесенные изменения?", "Сохранение измененний", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    switch (result)
                    {
                        case DialogResult.Yes:
                       
                          try
                            {
                                file = new FileStream(settingWords.PathBase, FileMode.OpenOrCreate);
                                Memory.Position = 0;
                                Memory.CopyTo(file);
                                Memory.Close();
                                Memory.Dispose();
                                file.Close();
                                file.Dispose();
                            }
                            catch
                            {
                                Memory.Close();
                                Memory.Dispose();
                                file.Close();
                                file.Dispose();
                                return SaveCheck(output);
                            }
                     
                            WordsList.MainCategory = output;
                            return true;
                        case DialogResult.No:
                            return true;
                        case DialogResult.Cancel:
                            return false;
                    }
                }
                
            }
            return true;
        }
        public static bool Save(WordsCategory output)
        {
            return Save(settingWords.PathBase, output);
        }
            public static bool Save(string path, object output)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = null;
            try
            {
                file = new FileStream(path, FileMode.OpenOrCreate);
                binaryFormatter.Serialize(file, output);
                file.Close();
                file.Dispose();
                return true;
            }
            catch
            {
                file.Close();
                file.Dispose();
                return SaveCheck(output);
               
            }
        }
        public static bool SaveCheck(object output)
        {
            DialogResult result1 = MessageBox.Show("Файл занят другой программой.\nПовторить еще раз?", "Ошибка сохранения", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            switch (result1)
            {
                case (DialogResult.Retry):
                    return SaveCheck(output);
                case (DialogResult.Abort):
                    return true;
            }
            return false;
        }


    }
}
