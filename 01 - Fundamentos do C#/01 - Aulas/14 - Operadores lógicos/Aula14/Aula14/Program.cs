using System;

namespace Aula14
{
    internal class Program
    {
        static void Main(string[] args)
        {                           
            int numero = 10;
            bool E = (numero > 0) && (numero > 100);
            Console.WriteLine(E);
            bool OU = (numero > 25) || (numero < 25);
            Console.WriteLine(OU);
            bool negacao = !(numero < 25);
            Console.WriteLine(negacao);
        }
    }
}
