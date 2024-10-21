using System;
using Aula03.Entities.Exceptions;

namespace Aula03.Entities
{
    public class Reserva
    {
        public int numeroQuarto {  get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainExpection("Não foi possível realizar a reserva, data do checkout deve ser maior a data do checkin");
            }

            this.numeroQuarto = numeroQuarto;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        public int Duracao()
        {
            TimeSpan duracao = checkOut.Subtract(checkIn);
            return (int)duracao.TotalDays;
        }

        public void AtualizarData(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainExpection("Erro na reserva, as datas devem futuras");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainExpection("Não foi possível realizar a reserva, data do checkout deve ser maior a data do checkin");
            }

            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        public override string ToString()
        {
            return "Número do quarto: "
                   + numeroQuarto
                   + ", Check-in: "
                   + checkIn.ToString("dd/MM/yyyy")
                    + ", Check-out: "
                   + checkOut.ToString("dd/MM/yyyy")
                   + ", Duração: "
                   + Duracao()
                   + " noites";  
        }
    }
}
