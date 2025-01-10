using System;
using System.Linq;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NomeCompleto = "Lucas Matheus";

            // Utilizando Lamba / Function anônima
            var Resultado = NomeCompleto.Where(p => p == 'a');

            foreach (var result in Resultado)
            {
                Console.WriteLine(result);
            }
        }
    }
}
