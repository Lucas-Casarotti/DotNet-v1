using System;

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExemploReplace();
        }

        public static void ExemploReplace()
        {
            string teste = "Curso Csharp";

            // Replace: é usado para substituir uma determinada palavra
            Console.WriteLine(teste);
            // Substituindo Csharp por C#
            Console.WriteLine(teste.Replace("Csharp", "C#"));
        }
    }
}
