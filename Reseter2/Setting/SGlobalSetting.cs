using Reseter2.History;
using Reseter2.Seacher;
using Reseter2.Words;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Reseter2.Setting
{
    [Serializable]
    internal static class SGlobalSetting 
    {
       
        public static SettingWords settingWords = new SettingWords();
        public static SettingExpand settingExpand = new SettingExpand();
        public static SettingSCCM settingSCCM = new SettingSCCM();
        public static SettingReboot settingReboot = new SettingReboot();

       //public static void LoadSetting()
       // {

            
       // }



        public static void LoadSetting()
        {
            object output = Load("res.dat");
            if (!(output is SSetting)) return;
            SSetting setting = (SSetting)output;
            if (setting.settingWords != null) settingWords = setting.settingWords;
            if (setting.settingExpand != null) settingExpand = setting.settingExpand;
            if (setting.settingSCCM != null) settingSCCM = setting.settingSCCM;
            if (setting.settingReboot != null) settingReboot = setting.settingReboot;
            HistoryList.Hitem = setting.historyItems;
            SSeaher.LoadSetting();
           // return output;
        }

        public static bool SaveSettig()
        {
            SSetting sSetting = new SSetting();
            sSetting.settingWords = settingWords;
            sSetting.historyItems = HistoryList.Hitem;
            sSetting.settingExpand = settingExpand;
            sSetting.settingSCCM = settingSCCM;
            sSetting.settingReboot = settingReboot;
            if (Save("res.dat", sSetting))
            {
                return true;
            }
            else
            {
                return false;
            }
            
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
            GZipStream compressStream = null;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = null;
            try
            {
                file = new FileStream(path, FileMode.Open);
                compressStream = new GZipStream(file, CompressionMode.Decompress);
                obj = binaryFormatter.Deserialize(compressStream);
                compressStream.Close();
                compressStream.Dispose();
                file.Close();
                file.Dispose();
                return obj;
            }
            catch
            {
                if (compressStream != null)
                {
                    compressStream.Close();
                    compressStream.Dispose();
                }
                if (file != null)
                {
                    file.Close();
                    file.Dispose();
                }
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
            GZipStream compressStream = null;
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

                    bool save = Save(output);
                    if (save) {
                        WordsList.MainCategory = output;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Сохранить внесенные изменения?", "Сохранение измененний", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    switch (result)
                    {
                        case DialogResult.Yes:
                       
                          try
                            {
                                file = new FileStream(settingWords.PathBase, FileMode.Create);
                                compressStream = new GZipStream(file, CompressionMode.Compress);
                                Memory.Position = 0;
                                Memory.CopyTo(compressStream);
                                Memory.Close();
                                Memory.Dispose();
                                compressStream.Close();
                                compressStream.Dispose();
                                file.Close();
                                file.Dispose();
                            }
                            catch
                            {
                                Memory.Close();
                                Memory.Dispose();
                                compressStream.Close();
                                compressStream.Dispose();
                                file.Close();
                                file.Dispose();
                             
                                
                                bool save = SaveCheck(settingWords.PathBase, output); ;
                                if (save)
                                {
                                    WordsList.MainCategory = output;
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
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
            GZipStream compressStream = null;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = null;
            try
            {
                file = new FileStream(path, FileMode.Create);
                compressStream = new GZipStream(file, CompressionMode.Compress);
                binaryFormatter.Serialize(compressStream, output);
                compressStream.Close();
                compressStream.Dispose();
                file.Close();
                file.Dispose();
                return true;
            }
            catch
            {
                if (compressStream != null)
                {
                    compressStream.Close();
                    compressStream.Dispose();
                }
                if (file != null)
                {
                    file.Close();
                    file.Dispose();
                }
               
                return SaveCheck(path, output);
               
            }
        }
        public static bool SaveCheck(string path, object output)
        {
            DialogResult result1 = MessageBox.Show("Файл занят другой программой.\nПовторить еще раз?", "Ошибка сохранения", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            switch (result1)
            {
                case (DialogResult.Retry):
                    return Save(path, output);
                case (DialogResult.Abort):
                    return true;
            }
            return false;
        }


    }
}
