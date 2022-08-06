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
            string result = string.Empty;
            if (numero % 3 == 0)
                result = "Fizz";
            if (numero % 5 == 0)
                result += "Buzz";

            return result == string.Empty? numero.ToString() : result;
        }

        private bool ValidaInteiro(string valor)
        {
            int valorCompara;
            return int.TryParse(valor, out valorCompara);
        }
    }
}
