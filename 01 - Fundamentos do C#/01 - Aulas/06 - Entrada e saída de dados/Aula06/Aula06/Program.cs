using System;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Olá, {0}", nome);

            Console.WriteLine($"Olá, {nome}");

            Console.WriteLine("Olá, " + nome);
        }
    }
}
