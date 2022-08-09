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
        public void IniciarValor1Test()
        {
            mocker.GetMock<IConsoleIO>()
                .SetupSequence(x => x.ReadLine())
                .Returns("1")
                .Returns("sair");

            var processamento = mocker.CreateInstance<Processamento>();

            //act
            processamento.Iniciar(null);

            //assert
            mocker.GetMock<IConsoleIO>().Verify(x => x.Write(It.IsAny<string>()), Times.Exactly(2));
            mocker.GetMock<IConsoleIO>().Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(1));
        }

        [TestMethod]
        public void IniciarValor3Test()
        {
            mocker.GetMock<IConsoleIO>()
                .SetupSequence(x => x.ReadLine())
                .Returns("3")
                .Returns("sair");

            var processamento = mocker.CreateInstance<Processamento>();

            //act
            processamento.Iniciar(null);

            //assert
            mocker.GetMock<IConsoleIO>().Verify(x => x.Write(It.IsAny<string>()), Times.Exactly(2));
            mocker.GetMock<IConsoleIO>().Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(1));
        }

        [TestMethod]
        public void IniciarValor5Test()
        {
            mocker.GetMock<IConsoleIO>()
                .SetupSequence(x => x.ReadLine())
                .Returns("5")
                .Returns("sair");

            var processamento = mocker.CreateInstance<Processamento>();

            //act
            processamento.Iniciar(null);

            //assert
            mocker.GetMock<IConsoleIO>().Verify(x => x.Write(It.IsAny<string>()), Times.Exactly(2));
            mocker.GetMock<IConsoleIO>().Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(1));
        }

        [TestMethod]
        public void IniciarValor75Test()
        {
            mocker.GetMock<IConsoleIO>()
                .SetupSequence(x => x.ReadLine())
                .Returns("75")
                .Returns("sair");

            var processamento = mocker.CreateInstance<Processamento>();

            //act
            processamento.Iniciar(null);

            //assert
            mocker.GetMock<IConsoleIO>().Verify(x => x.Write(It.IsAny<string>()), Times.Exactly(2));
            mocker.GetMock<IConsoleIO>().Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(1));
        }

        [TestMethod]
        public void IniciarValoresTest()
        {
            mocker.GetMock<IConsoleIO>()
                .SetupSequence(x => x.ReadLine())
                .Returns("1")
                .Returns("3")
                .Returns("sair");

            var processamento = mocker.CreateInstance<Processamento>();

            //act
            processamento.Iniciar(null);

            //assert
            mocker.GetMock<IConsoleIO>().Verify(x => x.Write(It.IsAny<string>()), Times.Exactly(3));
            mocker.GetMock<IConsoleIO>().Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(2));
        }
    }
}
