﻿using PonySFM_Desktop.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonySFM_Desktop
{
    public class ModManager
    {
        ///TODO: Use <see cref="System.Version"/> instead, if possible.
        public static int Version = 100;
        public static string PonySFMURL = "https://ponysfm.com";
        public static string ConfigLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\PonySFM";
        public static string ConfigFileLocation = ConfigLocation + "\\config.xml";
    }
}
