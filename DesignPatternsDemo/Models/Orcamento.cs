using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Models
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
        }
    }
}
