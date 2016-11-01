using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace demo_Hospital_scheduling.Config
{
    public class Config
    {
        public static string Provider = ConfigurationManager.AppSettings["Provider"];
        public static string Data_Source = ConfigurationManager.AppSettings["Data_Source"];
        public static string Initial_Catalog = ConfigurationManager.AppSettings["Initial_Catalog"];
        public static string User_Id = ConfigurationManager.AppSettings["User_Id"]; 
        public static string Password = ConfigurationManager.AppSettings["Password"];

        public static object uConfig { get; set; }
    }
    
}
