using FizzBuzz.Interfaces;

namespace FizzBuzz.Numbers
{
    public class Divisivel : INumero
    {
        public string FizzBuzz(int numero)
        {
            if (numero % 15 == 0)
                return "FizzBuzz";

            return Fizz(numero);
        }

        public string Fizz(int numero)
        {
            if (numero % 3 == 0)
                return "Fizz";

            return Buzz(numero);
        }

        public string Buzz(int numero)
        {
            if (numero % 5 == 0)
                return "Buzz";

            return MyName(numero);
        }

        public string MyName(int numero)
        {
            if (numero % 7 == 0)
                return "Meu Nome";

            return numero.ToString();
        }
    }
}