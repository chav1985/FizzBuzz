using FizzBuzz.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq.AutoMock;

namespace FizzBuzzTest
{
    [TestClass]
    public class ValidaFizzBuzzTests
    {
        private AutoMocker mocker;

        [TestInitialize]
        public void Setup()
        {
            mocker = new AutoMocker();
        }

        [TestMethod]
        public void ValidaFizzNumero3Test()
        {
            //arrange
            var validaFizzBuzz = mocker.CreateInstance<ValidaFizzBuzz>();

            //act
            string result = validaFizzBuzz.ValidaFizz(3);

            //assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void ValidaFizzNumero5Test()
        {
            //arrange
            var validaFizzBuzz = mocker.CreateInstance<ValidaFizzBuzz>();

            //act
            string result = validaFizzBuzz.ValidaFizz(5);

            //assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void ValidaFizzNumero7Test()
        {
            //arrange
            var validaFizzBuzz = mocker.CreateInstance<ValidaFizzBuzz>();

            //act
            string result = validaFizzBuzz.ValidaFizz(7);

            //assert
            Assert.AreEqual("Meu Nome", result);
        }

        [TestMethod]
        public void ValidaFizzNumero8Test()
        {
            //arrange
            var validaFizzBuzz = mocker.CreateInstance<ValidaFizzBuzz>();

            //act
            string result = validaFizzBuzz.ValidaFizz(8);

            //assert
            Assert.AreEqual("8", result);
        }
    }
}
