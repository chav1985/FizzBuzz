using FizzBuzz.Interfaces;
using System;
using System.Diagnostics.CodeAnalysis;

namespace FizzBuzz.Helpers
{
    [ExcludeFromCodeCoverage]
    public class ConsoleIO : IConsoleIO
    {
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public void WriteLine(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
