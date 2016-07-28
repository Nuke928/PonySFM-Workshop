﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonySFM_Desktop
{
    public interface IFile
    {
        string Path { get; }
        string Name { get; }
        bool IsDirectory();
        bool IsFile();
    }
}
