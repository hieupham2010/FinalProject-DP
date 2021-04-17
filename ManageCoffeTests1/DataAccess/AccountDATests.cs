using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManageCoffe.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataAccessLayer.Tests
{
    [TestClass()]
    public class AccountDATests
    {
        [TestMethod()]
        public void LoginTest()
        {
            bool result = AccountDA.Instance.Login("admin", "admin");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void LoginTest1()
        {
            bool result = AccountDA.Instance.Login("employee", "123456");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void LoginTest2()
        {
            bool result = AccountDA.Instance.Login("admin", "123456");
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void LoginTest3()
        {
            bool result = AccountDA.Instance.Login("employee", "abcdef");
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void CheckExistAccountTest()
        {
            bool result = AccountDA.Instance.CheckExistAccount("admin");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void CheckExistAccountTest1()
        {
            bool result = AccountDA.Instance.CheckExistAccount("employee");
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void CheckExistAccountTest2()
        {
            bool result = AccountDA.Instance.CheckExistAccount("fake1");
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void CheckExistAccountTest3()
        {
            bool result = AccountDA.Instance.CheckExistAccount("fake2");
            Assert.AreEqual(false, result);
        }
    }
}