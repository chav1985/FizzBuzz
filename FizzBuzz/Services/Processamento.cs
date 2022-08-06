using FizzBuzz.Interfaces;

namespace FizzBuzz.Services
{
    public class Processamento : IProcessamento
    {
        private readonly IConsoleIO _console;

        public Processamento(IConsoleIO console)
        {
            _console = console;
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
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (numero % 3 == 0)
            {
                return "Fizz";
            }
            else if (numero % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return numero.ToString();
            }
        }

        private bool ValidaInteiro(string valor)
        {
            int valorCompara;
            return int.TryParse(valor, out valorCompara);
        }
    }
}
