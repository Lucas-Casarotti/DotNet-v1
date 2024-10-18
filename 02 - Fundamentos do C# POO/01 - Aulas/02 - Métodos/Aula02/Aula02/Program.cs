using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();
            //var cal = new Calculadora();
            cal.n1 = 1;
            cal.n2 = 2;

            cal.adcao(cal.n1, cal.n2);
            Console.WriteLine(cal.total);

        }
    }
}
