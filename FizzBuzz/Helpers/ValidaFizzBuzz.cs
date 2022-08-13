namespace FizzBuzz.Helpers
{
    public class ValidaFizzBuzz : AbsValidaFizzBuzz
    {
        public override string ValidacaoBuzz(int numero)
        {
            if (numero % 5 == 0)
                return "Buzz";
            return ValidacaoMeuNome(numero);
        }

        private string ValidacaoMeuNome(int numero)
        {
            if (numero % 7 == 0)
                return "Meu Nome";
            return numero.ToString();
        }
    }
}
