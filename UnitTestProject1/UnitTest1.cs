using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp3;
using NUnit;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var vm = new EntryFieldVM();
            Assert.AreEqual("Username", vm.Username);
            Assert.AreEqual("Password", vm.Password);
            Assert.AreEqual("Email", vm.Email);
        }
    }
}
