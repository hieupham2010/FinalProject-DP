using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManageCoffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.Tests
{
    [TestClass()]
    public class Form_LoginTests
    {
        [TestMethod()]
        public void CheckLoginTest()
        {
            Form_Login login = new Form_Login();
            login.CheckLogin()
            Assert.Fail();
        }
    }
}