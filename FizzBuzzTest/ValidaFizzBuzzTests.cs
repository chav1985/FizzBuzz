using FizzBuzz.Helpers;
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
        public void ValidacaoBuzzTest()
        {
            //arrange
            var validaFizzBuzz = mocker.CreateInstance<ValidaFizzBuzz>();

            //act
            string result = validaFizzBuzz.ValidacaoBuzz(5);

            //assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void ValidacaoBuzzMeuNomeTest()
        {
            //arrange
            var validaFizzBuzz = mocker.CreateInstance<ValidaFizzBuzz>();

            //act
            string result = validaFizzBuzz.ValidacaoBuzz(7);

            //assert
            Assert.AreEqual("Meu Nome", result);
        }

        [TestMethod]
        public void ValidacaoBuzzNumeroTest()
        {
            //arrange
            var validaFizzBuzz = mocker.CreateInstance<ValidaFizzBuzz>();

            //act
            string result = validaFizzBuzz.ValidacaoBuzz(9);

            //assert
            Assert.AreEqual("9", result);
        }
    }
}
