using System;

namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExemploTrim();
        }

        public static void ExemploTrim()
        {
            string teste = "**LUCAS CASAROTTI**";
            Console.WriteLine("REMOVENDO ** COM TRIM");
            Console.WriteLine("DIFERENTES TIPOS DE TRIM:");
            Console.WriteLine("Trim:      " + teste.Trim('*'));
            Console.WriteLine("TrimStart: " + teste.TrimStart('*'));
            Console.WriteLine("TrimEnd:   " + teste.TrimEnd('*'));
        }
    }
}
