using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios02
{
    public class Funcionario
    {
        public int id {  get; set; }
        public string nome { get; set; }
        public double salario { get; set; }


        public Funcionario(int id, string nome, double salario)
        {
            this.id = id;
            this.nome = nome;
            this.salario = salario;
        }

        public override string ToString()
        {
            return $"Código: {id}, Nome: {nome} e Salário: {salario}";
        }
    }
}
