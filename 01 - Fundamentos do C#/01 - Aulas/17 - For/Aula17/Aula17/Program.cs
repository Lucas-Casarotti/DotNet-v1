using System;

namespace Aula17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            Console.WriteLine("Digite até que número deseja ser imprimido: ");
            qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i <= qtd; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
