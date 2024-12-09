using System;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();
            ToLower.ConverterToLower(frase);
            ToUpper.ConverterToUpper(frase);
        }
    }
}
