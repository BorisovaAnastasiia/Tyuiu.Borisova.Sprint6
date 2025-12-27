using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.Borisova.Sprint6.Task5.V16.Lib;

namespace Tyuiu.Borisova.Sprint6.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.Borisova.Sprint6\Tyuiu.Borisova.Sprint6.Task5.V16\bin\Debug\InPutFileTask5V16.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}