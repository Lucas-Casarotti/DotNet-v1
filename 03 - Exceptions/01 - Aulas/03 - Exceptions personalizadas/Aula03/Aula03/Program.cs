using Aula03.Entities;
using Aula03.Entities.Exceptions;
using System;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bem vindo ao Hotel do Luquinhas");
                Console.WriteLine("Digite o número do quarto: ");
                int numQuarto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a data do checkin (dd/MM/yyy): ");
                DateTime checkIn = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Digite a data do checkout (dd/MM/yyy): ");
                DateTime checkOut = Convert.ToDateTime(Console.ReadLine());

                Reserva reserva = new Reserva(numQuarto, checkIn, checkOut);

                Console.WriteLine(reserva);

                Console.WriteLine();
                Console.WriteLine("Informe os dados para atualizar a data da reserva: ");
                Console.WriteLine("Digite a data do checkin (dd/MM/yyy): ");
                checkIn = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Digite a data do checkout (dd/MM/yyy): ");
                checkOut = Convert.ToDateTime(Console.ReadLine());

                reserva.AtualizarData(checkIn, checkOut);
                Console.WriteLine(reserva);
            }
            catch (DomainExpection ex)
            {
                Console.WriteLine("Erro na reserva: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro de formatação: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado: " + ex.Message);
            }
        }
    }
}
