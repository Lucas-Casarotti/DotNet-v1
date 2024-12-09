using System;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExemploStartWithEndsWith();
        }

        public static void ExemploStartWithEndsWith()
        {
            string teste = "Curso Csharp";
            // StartsWith: verifica se determinada palavra está no inicio da string
            Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));
            // EndsWith: verifica se determinada palavra está no final da string
            Console.WriteLine("FINAL:  " + teste.EndsWith("Csharp02"));
        }
    }
}
