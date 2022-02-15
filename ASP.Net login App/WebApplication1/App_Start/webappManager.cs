using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Start
{
    public class AdminSettings
    {
        public string DefaultPageText1 { get; set; }
        public string DefaultPageText2 { get; set; }
        public string headerText { get; set; }
        public string footerText { get; set; }

    }
    public class webappManager
    {
       
        public webappManager()
        {


        }
        public static AdminSettings LoadSettings(string FilePath)
        {
            AdminSettings Settings = new AdminSettings();
            try {
                
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(AdminSettings));
                System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
                AdminSettings overview = (AdminSettings)reader.Deserialize(file);
                file.Close();
                return Settings;
            }
            catch (Exception)
            {
                return Settings;
            }
        }
        public static void SaveSetting(string FilePath,AdminSettings SettingsObj)
        {
            System.Xml.Serialization.XmlSerializer writer =
           new System.Xml.Serialization.XmlSerializer(typeof(AdminSettings));

           
            System.IO.FileStream file = System.IO.File.Create(FilePath);

            writer.Serialize(file, SettingsObj);
            file.Close();
        }
        public static AdminSettings LoadDSettings(String FilePath)
        {
            AdminSettings settings = new AdminSettings();
            try
            {

                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(AdminSettings));
                System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
                settings = (AdminSettings)reader.Deserialize(file);
                file.Close();
                return settings;
            }
            catch (Exception)
            {
                return settings;

            }

        }
        public static void SaveDSettings(string FilePath, AdminSettings SettingsObject)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(AdminSettings));

            System.IO.FileStream file = System.IO.File.Create(FilePath);
            writer.Serialize(file, SettingsObject);
        }
    }




}