using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactioning_Towards5_3.Mocking;

namespace FakeFileReader5_3.UnitTests
{
   public class FakeFileReader : IFileReader
   {
        public string Read(string path)
        {
            throw new System.NotImplementedException();
        }
   }
}
