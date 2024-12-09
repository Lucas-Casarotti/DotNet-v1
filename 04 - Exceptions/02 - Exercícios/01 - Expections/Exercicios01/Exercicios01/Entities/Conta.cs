using Exercicios01.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios01.Entities
{
    public class Conta
    {
        public int numeroConta { get; set; }
        public string titularConta { get; set; }
        public double saldoConta { get; set; }
        public double limiteSaque { get; } = 7500;

        public Conta(int numeroConta, string titularConta, double saldoConta)
        {
            this.numeroConta  = numeroConta;
            this.titularConta = titularConta;
            this.saldoConta = saldoConta;
        }

        public void Opcao(int opc)
        {
            double valor;

            if ( opc == 1)
            {
                Console.WriteLine("Informe o valor a ser depositado:");
                valor = Convert.ToDouble(Console.ReadLine());
                Depositar(valor);
            }
            else if ( opc == 2)
            {
                Console.WriteLine("Informe o valor a ser sacado: ");
                valor = Convert.ToDouble(Console.ReadLine());
                Sacar(valor);
            }
        }

        public void Depositar(double valor)
        {
            this.saldoConta = this.saldoConta + valor;
        }

        public void Sacar(double valor)
        {
            if (valor > limiteSaque)
            {
                throw new ContaException("Limite insuficente para saque");
            }
            if (valor > saldoConta)
            {
                throw new ContaException("Saldo insuficente para saque");
            }

            this.saldoConta -= valor;
        }

        public override string ToString()
        {
            return "Dados da conta:"
                  + "Número da conta: "
                  + numeroConta
                  + ", Titular da conta: "
                  + titularConta
                  + ", Saldo atual: "
                  + saldoConta
                  + ", Limite disponível para saque: "
                  + limiteSaque;

        }
    }
}
