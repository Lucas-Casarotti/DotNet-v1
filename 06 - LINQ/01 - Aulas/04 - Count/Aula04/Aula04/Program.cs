using System;
using System.Linq;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new int[] {1, 2, 3, 4, 5};

            // Utilizando o Count para contar a quantidade de elementos
            // Também é possível adicionar condições
            var resultado = numeros.Count(p => p > 2);

            Console.WriteLine(resultado);
        }
    }
}
