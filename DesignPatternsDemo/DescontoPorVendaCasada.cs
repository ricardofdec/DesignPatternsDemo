using DesignPatternsDemo.Interfaces;
using DesignPatternsDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            if(Existe("LAPIS", orcamento) || Existe("CANETA", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            return 0;
        }

        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
