using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Password.Tests
{
    [TestClass]
    public class PassTest
    {
        [TestMethod]
        public void CheckPassword_CheckNumber_1score()
        {
            // arrange
            string password = "1567";
            var pass = new Password.Pass();
            int expected = 1;
            // act
            int result = pass.CheckPasswordNumber(password);
            // assert
            Assert.AreEqual(expected, result);
            Console.WriteLine("1 балл");
        }

        [TestMethod]
        public void CheckPassword_CheckLower_1score()
        {
            // arrange
            string password = "effef";
            var pass = new Password.Pass();
            int expected = 1;
            // act
            int result = pass.CheckPasswordLower(password);
            // assert
            Assert.AreEqual(expected, result);
            Console.WriteLine("1 балл");
        }

        [TestMethod]
        public void CheckPassword_CheckUpper_1score()
        {
            // arrange
            string password = "FEfjdf";
            var pass = new Password.Pass();
            int expected = 1;
            // act
            int result = pass.CheckPasswordUpper(password);
            // assert
            Assert.AreEqual(expected, result);
            Console.WriteLine("1 балл");
        }

        [TestMethod]
        public void CheckPassword_CheckSpecialSymbol_1score()
        {
            // arrange
            string password = "gf@dse_";
            var pass = new Password.Pass();
            int expected = 1;
            // act
            int result = pass.CheckPasswordSymbol(password);
            // assert
            Assert.AreEqual(expected, result);
            Console.WriteLine("1 балл");
        }

        [TestMethod]
        public void CheckPassword_CheckLength_1score()
        {
            // arrange
            string password = "gfdtbydseyh";
            var pass = new Password.Pass();
            int expected = 1;
            // act
            int result = pass.CheckPasswordLength(password);
            // assert
            Assert.AreEqual(expected, result);
            Console.WriteLine("1 балл");
        }

        [TestMethod]
        public void CheckPassword_CheckAll_5score()
        {
            // arrange
            string password = "f2fF1@g_fyk";
            var pass = new Password.Pass();
            int expected = 5;
            // act
            int result = pass.CheckPasswordNumber(password) + pass.CheckPasswordLower(password) + pass.CheckPasswordUpper(password) + pass.CheckPasswordSymbol(password) + pass.CheckPasswordLength(password);
            // assert
            Assert.AreEqual(expected, result);
            Console.WriteLine("5 балл");
        }
    }
}