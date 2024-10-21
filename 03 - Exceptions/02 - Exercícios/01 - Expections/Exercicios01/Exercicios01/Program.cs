using Exercicios01.Entities;
using Exercicios01.Entities.Exceptions;
using System;
using System.IO;

namespace Exercicios01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int opc;
                do
                {
                    Console.WriteLine("Banco Casagood");
                    Console.WriteLine("1 - Iniciar programa 2 - Finalizar programa");
                    opc = Convert.ToInt32(Console.ReadLine());

                    if (opc == 1)
                    {
                        Console.WriteLine("Digite o número da sua conta:");
                        int numeroConta = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o nome do titular da conta:");
                        string nomeConta = Console.ReadLine();
                        Console.WriteLine("Digite o saldo atual");
                        double saldoConta = Convert.ToDouble(Console.ReadLine());
                        Conta conta = new Conta(numeroConta, nomeConta, saldoConta);

                        Console.WriteLine("Digite a operação");
                        Console.WriteLine("1 - Depositar 2 - Sacar");
                        int opc2 = Convert.ToInt32(Console.ReadLine());
                        conta.Opcao(opc2);

                        Console.WriteLine(conta);
                    }

                } while (opc != 2);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Erro na operação: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado: " + ex.Message);
            }
        }
    }
}
