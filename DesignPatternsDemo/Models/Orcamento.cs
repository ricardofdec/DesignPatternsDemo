using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Models
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; set; } = new List<Item>();
        public Orcamento(double valor)
        {
            this.Valor = valor;
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
