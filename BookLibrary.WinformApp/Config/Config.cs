using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WinformApp
{
    public partial class Config
    {
        static private Config _instance;
        private const string SettingFileName = "Settings.xml";

        static public Config Settings { 
            get{
                if(_instance == null)
                {
                    string path = GetFullName();

                    if (File.Exists(path))
                    {
                        string xmlRead = File.ReadAllText(path);
                        _instance = XmlConvertor.XmlDeserialization<Config>(xmlRead);
                    }
                    else
                    {
                        _instance = new Config();
                    }
                    _instance.Setup();
                }
                return _instance;
            }
            private set { } 
        }
        public void Setup()
        {
            XmlConvertor.Serialize(GetFullName(), this);
        }

        static private string GetFullName()
        {
            return System.Windows.Forms.Application.StartupPath + Path.DirectorySeparatorChar + SettingFileName;
        }
    }
}
