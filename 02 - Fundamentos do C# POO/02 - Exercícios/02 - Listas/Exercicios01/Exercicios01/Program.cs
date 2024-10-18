using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdProduto, opc;
            Console.WriteLine("Digite a quantidade de produtos: ");
            qtdProduto = Convert.ToInt32(Console.ReadLine());

            List<Produto> lista = new List<Produto>();

            for (int i = 0; i < qtdProduto; i++)
            {
                Console.WriteLine("Código do produto:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nome do produto:");
                string nome = Console.ReadLine();
                Console.WriteLine("Valor do produto:");
                decimal valor = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Quantidade:");
                int quantidade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                lista.Add(new Produto (id, nome, valor, quantidade));
            }

            do
            {
                Console.WriteLine("1 - Deseja adicionar mais algum produto?");
                Console.WriteLine("2 - Deseja remover algum produto?");
                Console.WriteLine("3 - Prosseguir para o pagamento");
                Console.WriteLine();
                opc = Convert.ToInt32(Console.ReadLine());

                if (opc == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Código do produto:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nome do produto:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Valor do produto:");
                    decimal valor = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Quantidade:");
                    int quantidade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    lista.Add(new Produto(id, nome, valor, quantidade));
                }
                else if (opc == 2)
                {
                    foreach (Produto produto in lista)
                    {
                        Console.WriteLine(produto);
                    }

                    Console.WriteLine("Digite o código do produto que deseja remover: ");
                    Console.WriteLine();
                    int idProduto = Convert.ToInt32(Console.ReadLine());

                    var itemRemovido = lista.Single(x => x.id ==  idProduto);
                    lista.Remove(itemRemovido);
                }

            } while (opc == 1 || opc == 2);
            
            foreach (Produto produto in lista)
            {
                Console.WriteLine();
                Console.WriteLine(produto);
            }
        }
    }
}
