using System;

namespace Aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExemploLength();
        }

        public static void ExemploLength()
        {
            string teste = Console.ReadLine();
            // Length: retorna a quantidade de caracteres da variável
            Console.WriteLine(teste.Length);
        }
    }
}
