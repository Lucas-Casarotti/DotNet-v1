using System;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // programa sem tratamento de exceção
            //int n1, n2, result;
            //Console.WriteLine("Divisão de dois números");
            //Console.WriteLine("Digite o primeiro número: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo número: ");
            //n2 = int.Parse(Console.ReadLine());

            //result = n1 / n2;
            //Console.WriteLine("Total: " + result);


            // programa com tratamento de exceção
            try
            {
                int n1, n2, result;
                Console.WriteLine("Divisão de dois números");
                Console.WriteLine("Digite o primeiro número: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                n2 = int.Parse(Console.ReadLine());

                result = n1 / n2;
                Console.WriteLine("Total: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível realizar a divisão por 0");
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao realizar divisão");
            }
        }
    }
}
