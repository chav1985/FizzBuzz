using FizzBuzz.Helpers;
using FizzBuzz.Interfaces;

namespace FizzBuzz.Services
{
    public class Processamento : IProcessamento
    {
        private readonly IConsoleIO _console;
        private readonly ValidaFizzBuzz _validaFizzBuzz;

        public Processamento(IConsoleIO console, ValidaFizzBuzz validaFizzBuzz)
        {
            _console = console;
            _validaFizzBuzz = validaFizzBuzz;
        }

        public void Iniciar(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string result = ValidaNumero(i);
                _console.WriteLine(result);
            }
            _console.ReadKey();
        }

        public string ValidaNumero(int numero)
        {
            return _validaFizzBuzz.ValidacaoFizzBuzz(numero);
        }
    }
}
