using FizzBuzz.Interfaces;

namespace FizzBuzz.Services
{
    public class Processamento : IProcessamento
    {
        private readonly IConsoleIO _console;
        private readonly INumero _numero;

        public Processamento(IConsoleIO console, INumero numero)
        {
            _console = console;
            _numero = numero;
        }

        public void Iniciar(string[] args)
        {
            string result = string.Empty;
            do
            {
                _console.Clear();
                _console.Write("Digite um numero para validar ou digite sair: ");
                result = _console.ReadLine();

                if (ValidaInteiro(result))
                {
                    string response = ValidaNumero(int.Parse(result));
                    _console.WriteLine(response);
                    _console.ReadKey();
                }
            } while (result.ToLower() != "sair");
        }

        public string ValidaNumero(int numero)
        {
            return _numero.FizzBuzz(numero);
        }

        private bool ValidaInteiro(string valor)
        {
            int valorCompara;
            return int.TryParse(valor, out valorCompara);
        }
    }
}
