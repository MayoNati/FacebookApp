using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public bool RemmeberUser { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(1149, 900);
            RemmeberUser = false;
            LastAccessToken = null;
        }

        public void SaveToFile()
        {
            FileMode fileMode;
            fileMode = File.Exists(@"c:\logs\appSettings.xml") ? FileMode.Truncate : FileMode.Create;
            using (Stream stream = new FileStream(@"c:\logs\appSettings.xml", fileMode))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings obj = new AppSettings();
            if (File.Exists(@"c:\logs\appSettings.xml"))
            {
                using (Stream stream = new FileStream(@"c:\logs\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }

    }
}

