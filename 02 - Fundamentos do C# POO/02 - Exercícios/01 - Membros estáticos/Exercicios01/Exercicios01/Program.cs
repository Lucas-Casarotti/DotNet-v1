using System;

namespace Exercicios01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            Console.WriteLine("Casa de câmbio");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Informar a cotação atual do dólar");
            Console.WriteLine("2 - Realizar a troca de reais em dólares");
            opc = Convert.ToInt32(Console.ReadLine());

            if( opc == 1 )
            {
                Console.WriteLine("Cada dolar está custando " + ConversorDeMoedas.CotacaoDolar() + " Real brasileiro");
            }
            if( opc == 2 )
            {
                Console.WriteLine("Qual a quantidade de reais que gostaria de converter?");
                int qtd = Convert.ToInt32(Console.ReadLine());
                ConversorDeMoedas.Conversao(qtd);
                double valor = ConversorDeMoedas.ValorConvertido;
                Console.WriteLine("Valor convertido em dólares com a aplicação da taxa de 6% de IOF");
                Console.WriteLine("Valor a receber: " + valor.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("pt-BR")));
            }
        }
    }
}
