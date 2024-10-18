using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PasswordCheck.Tests
{
    [TestClass]
    public class PassCheckTests
    {
        [TestMethod]
        public void CheckPassword_passwordcheck_returned0()
        {
            string password = "илья";
            int expected = 0;
            PassCheck PassCheck = new PassCheck();
            int actual = PassCheck.CheckPassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword_passwordcheck_returned1()
        {
            string password = "aaa";
            int expected = 1;
            PassCheck PassCheck = new PassCheck();
            int actual = PassCheck.CheckPassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword_passwordcheck_returned2()
        {
            string password = "Ilusha";
            int expected = 2;
            PassCheck PassCheck = new PassCheck();
            int actual = PassCheck.CheckPassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword_passwordcheck_returned3()
        {
            string password = "Ilysha18";
            int expected = 3;
            PassCheck PassCheck = new PassCheck();
            int actual = PassCheck.CheckPassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword_passwordcheck_returned4()
        {
            string password = "Ilusha18&";
            int expected = 4;
            PassCheck PassCheck = new PassCheck();
            int actual = PassCheck.CheckPassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword_passwordcheck_returned5()
        {
            string password = "IlyaEgorovP50-5@";
            int expected = 5;
            PassCheck PassCheck = new PassCheck();
            int actual = PassCheck.CheckPassword(password);
            Assert.AreEqual(expected, actual);
        }
    }
}