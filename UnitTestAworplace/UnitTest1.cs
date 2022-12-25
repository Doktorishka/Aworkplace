using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestAworplace
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Method_AddReader()
        {
            string lastName = "Иванов";
            string firstName = "Иван";
            string patromymic = "Иванович";
            DateTime dateTime = DateTime.Now;
            int selectedItem = 1;
            string place = "Работа";

            Assert.AreEqual(lastName, firstName);
        }
    }
}
