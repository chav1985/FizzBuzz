namespace FizzBuzz.Helpers
{
    public abstract class AbsValidaFizzBuzz
    {
        public string ValidacaoFizzBuzz(int numero)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
                return "FizzBuzz";
            return ValidacaoFizz(numero);
        }

        private string ValidacaoFizz(int numero)
        {
            if (numero % 3 == 0)
                return "Fizz";
            return ValidacaoBuzz(numero);
        }

        public abstract string ValidacaoBuzz(int numero);
    }
}
