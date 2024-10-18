using System;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            try
            {
                Console.WriteLine("Venda de ingressos Deadpool 2");
                Console.WriteLine("Digite sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
            }catch (Exception)
            {
                Console.WriteLine("Digite uma idade válida");
            }
            finally
            {
                // é executado mesmo que ocorra uma exception
                Console.WriteLine("Encerrando o programada...");
            }
           
        }
    }
}
