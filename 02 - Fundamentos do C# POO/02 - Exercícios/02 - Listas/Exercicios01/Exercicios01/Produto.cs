using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios01
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public decimal valor { get; set; }
        public int quantidade { get; set; }

        public Produto(int id, string nome, decimal valor, int quantidade)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"Código do produto: {id}, Nome do produto: {nome}, " +
                   $"Valor do produto: {valor} e Quantidade do produto {quantidade}"
;        }
    }
}
