using System;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();
            Substring.UtilizandoSubstring(frase);
        }
    }
}
