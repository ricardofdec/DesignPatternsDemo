using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class ItemNota
    {
        public String Nome { get; set; }
        public double Valor { get; set; }

        public ItemNota(String nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
