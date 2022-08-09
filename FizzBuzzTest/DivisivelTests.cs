using FizzBuzz.Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTest
{
    [TestClass]
    public class DivisivelTests
    {
        private Divisivel divisivel;
        
        [TestInitialize]
        public void Setup()
        {
            divisivel = new Divisivel();
        }

        [TestMethod]
        public void FizzBuzzNumber15Test()
        {
            string result = divisivel.FizzBuzz(15);
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void FizzBuzzNumber1Test()
        {
            string result = divisivel.FizzBuzz(1);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void FizzNumber3Test()
        {
            string result = divisivel.Fizz(3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void FizzNumber4Test()
        {
            string result = divisivel.Fizz(4);
            Assert.AreEqual("4", result);
        }

        [TestMethod]
        public void BuzzNumber5Test()
        {
            string result = divisivel.Fizz(5);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void BuzzNumber6Test()
        {
            string result = divisivel.Fizz(6);
            Assert.AreEqual("Fizz", result);
        }


        [TestMethod]
        public void MyNameNumber7Test()
        {
            string result = divisivel.MyName(7);
            Assert.AreEqual("Meu Nome", result);
        }

        [TestMethod]
        public void MyNameNumber8Test()
        {
            string result = divisivel.MyName(8);
            Assert.AreEqual("8", result);
        }
    }
}
