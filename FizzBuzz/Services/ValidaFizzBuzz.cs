using FizzBuzz.Interfaces;

namespace FizzBuzz.Services
{
    public class ValidaFizzBuzz : IValidaFizzBuzz
    {
        private string textoValidado;
        public string ValidaFizz(int numero)
        {
            textoValidado = string.Empty;
            if (numero % 3 == 0)
                textoValidado += "Fizz";
            return ValidaBuzz(numero);
        }

        public string ValidaBuzz(int numero)
        {
            if (numero % 5 == 0)
                textoValidado += "Buzz";
            return ValidaNome(numero);
        }

        private string ValidaNome(int numero)
        {
            if (numero % 7 == 0)
                textoValidado = "Meu Nome";
            return textoValidado == string.Empty ? numero.ToString() : textoValidado;
        }
    }
}
