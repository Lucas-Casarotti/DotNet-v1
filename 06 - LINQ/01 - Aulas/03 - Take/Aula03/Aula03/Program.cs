using System;
using System.Linq;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Utilizando Take para pegar uma parte de uma coleção
            var numeros = new int[] { 5, 4, 3, 2, 1 };

            var resultado = numeros.Take(3);

            foreach (int numero in resultado)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("");

            // Ordenando os valores pegos pelo Take
            // Também é possível adicionar uma condição
            var resultadoOrdenado = numeros.Where(p => p <4).Take(3).OrderBy(x => x);

            foreach (int numero in resultadoOrdenado)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
