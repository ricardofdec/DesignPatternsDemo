using DesignPatternsDemo.Interfaces;
using DesignPatternsDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class DescontoMaisQuinhentosReias : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Desconto(Orcamento orcamento)
        {
            return orcamento.Valor > 500 ? orcamento.Valor * 0.07 : Proximo.Desconto(orcamento);
        }
    }
}
