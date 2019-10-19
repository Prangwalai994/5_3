﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactioning_Towards5_3.Mocking
{
    public interface IFileReader
    {
        string Read(string path);
    }
    public class FileReader : IFileReader
    {
        public string Read(string path)
        {
             return File.ReadAllText(path);
        }
    }
}
