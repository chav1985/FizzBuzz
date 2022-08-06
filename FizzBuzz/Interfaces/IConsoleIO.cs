using System;

namespace FizzBuzz.Interfaces
{
    public interface IConsoleIO
    {
        void Write(string texto);
        void WriteLine(string texto);
        string ReadLine();
        ConsoleKeyInfo ReadKey();
        void Clear();
    }
}
