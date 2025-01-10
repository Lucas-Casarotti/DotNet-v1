using System;
using System.Linq;

namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new int[] { 1, 2, 3, 4, 5 };

            // Utilizando o First para pegar o primeiro elemento da coleção
            // Também é possível adicionar condições
            // Utilizando o FirstOrDefault para não retonar um erro caso não encontrar um número
            var resultado = numeros.FirstOrDefault(p => p >10);

            Console.WriteLine(resultado);
        }
    }
}
