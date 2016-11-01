using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FileIO
{
    public class ConfigFileIO
    {

        public static Dictionary<string, string> getConfigValue(string fileMap, Dictionary<string, string> configNameList)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = fileMap;
            try
            {

                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

                foreach (string _key in configNameList.Keys)
                {
                    if (config.AppSettings.Settings[configNameList[_key].ToString()].Value == null)
                    {
                        dictionary.Add(_key, "");
                    }
                    else
                    {
                        string _value = config.AppSettings.Settings[configNameList[_key].ToString()].Value.ToString();
                        dictionary.Add(_key, _value);
                    }
                }

                return dictionary;

            }
            catch (ConfigurationErrorsException e)
            {
                System.Console.WriteLine("配置文件读写异常，发生了错误，错误信息：" + e.Message);
                return new Dictionary<string, string>();
            }
        }
    }
}