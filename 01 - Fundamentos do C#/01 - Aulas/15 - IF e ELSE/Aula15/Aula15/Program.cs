using System;

namespace Aula15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }
        }
    }
}
