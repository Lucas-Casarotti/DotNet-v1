using System;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite alguns nomes:");
            string nomes = Console.ReadLine();
            Split.UtilizandoSplit(nomes);
        }
    }
}
