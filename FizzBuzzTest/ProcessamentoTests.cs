using FizzBuzz.Interfaces;
using FizzBuzz.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.AutoMock;

namespace FizzBuzzTest
{
    [TestClass]
    public class ProcessamentoTests
    {
        private AutoMocker mocker;

        [TestInitialize]
        public void Setup()
        {
            mocker = new AutoMocker();
            mocker.Use(new Mock<IConsoleIO>());
        }

        [TestMethod]
        public void IniciarTest()
        {
            //arrange
            var processamento = mocker.CreateInstance<Processamento>();

            //act
            processamento.Iniciar(null);

            //assert
            mocker.GetMock<IConsoleIO>().Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(100));
        }
    }
}
