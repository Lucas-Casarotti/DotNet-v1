using System;
using System.Collections.Generic;

namespace Exercicios02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários serão cadastrados?");
            int n = Convert.ToInt32(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Código do funcionário:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nome do funcionário:");
                string nome = Console.ReadLine();
                Console.WriteLine("Salário do funcionário:");
                double salario = Convert.ToDouble(Console.ReadLine());
                
                list.Add(new Funcionario(id, nome, salario));

                // pulando linha
                Console.WriteLine();
            }

            foreach (Funcionario funcionario in list)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}
