﻿using System.Xml;

namespace PonySFM_Desktop
{
    /* TODO: instead of just accepting one string as param this class should hold a list of attributes with a dictionary */
    public class ConfigFile
    {
        public string SFMDirectoryPath { get; set; }

        public ConfigFile(string sfmDirPath)
        {
            SFMDirectoryPath = sfmDirPath;
        }

        public static ConfigFile FromXML(XmlElement elem)
        {
            return new ConfigFile(elem.GetAttribute("SFMDirectoryPath"));
        }

        public XmlElement ToXML(XmlDocument doc)
        {
            XmlElement elem = doc.CreateElement("Config");
            elem.SetAttribute("SFMDirectoryPath", SFMDirectoryPath);
            return elem;
        }

        public bool Equals(ConfigFile other)
        {
            return other.SFMDirectoryPath == SFMDirectoryPath;
        }
    }
}
