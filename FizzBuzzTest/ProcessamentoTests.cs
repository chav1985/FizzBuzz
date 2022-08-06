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
        public void IniciarTestValor1()
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
        public void IniciarTestValor3()
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
        public void IniciarTestValor5()
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
        public void IniciarTestValor75()
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
        public void IniciarTestValores()
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
