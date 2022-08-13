using FizzBuzz.Helpers;
using FizzBuzz.Interfaces;
using FizzBuzz.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace FizzBuzz
{
    [ExcludeFromCodeCoverage]
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IProcessamento, Processamento>()
                .AddSingleton<IConsoleIO, ConsoleIO>()
                .AddSingleton<ValidaFizzBuzz>()
                .BuildServiceProvider();

            serviceProvider.GetService<IProcessamento>().Iniciar(args);
        }
    }
}