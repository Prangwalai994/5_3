using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactioning_Towards5_3.Mocking
{
    public class FileReader
    {
        public string Read(string path)
        {
             return File.ReadAllText(path);
        }
    }
}
