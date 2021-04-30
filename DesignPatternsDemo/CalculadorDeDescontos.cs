using DesignPatternsDemo.Interfaces;
using DesignPatternsDemo.Models;

namespace DesignPatternsDemo
{
    public class CalculadorDeDescontos 
    {
        public CalculadorDeDescontos ProximoDesconto { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            Desconto d1 = new DescontoPorCintoItens();
            Desconto d2 = new DescontoMaisQuinhentosReias();
            Desconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconto(orcamento);
        }
    }
}
