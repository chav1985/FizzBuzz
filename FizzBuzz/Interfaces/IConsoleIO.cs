using System;

namespace FizzBuzz.Interfaces
{
    public interface IConsoleIO
    {
        void WriteLine(string texto);
        ConsoleKeyInfo ReadKey();
    }
}
