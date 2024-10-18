using System;

namespace Aula22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// VALUE TYPES
            int x = 10;
            int y = x;
            x = 20;
            Console.WriteLine("Valor de x:" + x);
            Console.WriteLine("Valor de y:" + y);

            // REFERENCE TYPES
            int[] primeiroArray = new int[1];
            int[] segundoArray = primeiroArray;

            primeiroArray[0] = 1;
            Console.WriteLine("Valor do primeiro array:" + primeiroArray[0]);
            Console.WriteLine("Valor do segundo array :" + segundoArray[0]);

            primeiroArray[0] = 20;
            Console.WriteLine("Valor do primeiro array:" + primeiroArray[0]);
            Console.WriteLine("Valor do segundo array :" + segundoArray[0]);
        }
    }
}
