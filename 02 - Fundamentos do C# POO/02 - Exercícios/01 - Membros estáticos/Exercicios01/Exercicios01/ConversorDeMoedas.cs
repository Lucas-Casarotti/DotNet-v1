using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercicios01
{
    public static class ConversorDeMoedas
    {
        public static double Cotacao = 4.91;
        public static double ValorConvertido;
        
        public static double CotacaoDolar()
        {
            return Cotacao;
        }

        public static void Conversao(double qtd)
        {
            ValorConvertido = (qtd / Cotacao) * 0.94;
        }
    }
}
