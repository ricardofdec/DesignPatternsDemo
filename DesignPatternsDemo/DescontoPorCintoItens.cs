using DesignPatternsDemo.Interfaces;
using DesignPatternsDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class DescontoPorCintoItens : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Desconto(Orcamento orcamento)
        {
            return orcamento.Itens.Count > 5 ? orcamento.Valor * 10 : Proximo.Desconto(orcamento);
        }
    }
}
