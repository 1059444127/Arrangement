using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileIO;
/// <summary>
/// create by chenzhaoquan
/// </summary>
namespace DAL
{
    public class LoadDBInfo
    {
        public static string provider;
        public static string data_source;
        public static string initial_catalog;
        public static string user_id;
        public static string password;

        public void loadDBInfo()
        {

            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("provider", "provider");
            dic.Add("data_source", "data_source");
            dic.Add("initial_catalog", "initial_catalog");
            dic.Add("user_id", "user_id");
            dic.Add("password", "password");

            string fileMap = @"../../DBInfo.config";

            Dictionary<string, string> dbinfodic = ConfigFileIO.getConfigValue(fileMap, dic);

            provider = dbinfodic["provider"].ToString();
            data_source = dbinfodic["data_source"].ToString();
            initial_catalog = dbinfodic["initial_catalog"].ToString();
            user_id = dbinfodic["user_id"].ToString();
            password = dbinfodic["password"].ToString();

        }

    }
}
