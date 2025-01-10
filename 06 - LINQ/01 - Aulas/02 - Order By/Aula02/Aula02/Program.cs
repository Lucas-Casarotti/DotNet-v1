using System;
using System.Linq;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new int[] { 10, 9, 8, 7, 6, 1, 2, 3 };

            // Ordenando do menor para o maior
            var resultado = numeros.OrderBy(p => p);

            // Ordenando do maior para o menor
            //var resultado2 = numeros.OrderByDescending(p => p);

            foreach (int numero in resultado)
            {
                Console.WriteLine(numero);
            }

            // Também é possível ordenar strings
            var nomes = new string[] { "Lucas", "Luis", "Ione", "Marta" };
            var NomesOrdenados = nomes.OrderBy(p => p);

            foreach (string nome in NomesOrdenados)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
