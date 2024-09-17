using System;

namespace Aula10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valorString = "100";
            int valor = Convert.ToInt32(valorString);
            Console.WriteLine(valor);

            int valor2 = 100;
            string valorString2 = Convert.ToString(valor2);
            Console.WriteLine(valorString2);
        }

    }
}
