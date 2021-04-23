using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class EmpresaFilial
    {
        public String Nome { get; set; }
        public double Valor { get; set; }

        public EmpresaFilial(String nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
