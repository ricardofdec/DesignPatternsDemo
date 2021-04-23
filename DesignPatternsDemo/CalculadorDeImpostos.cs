using DesignPatternsDemo.Interfaces;
using DesignPatternsDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class CalculadorDeImpostos 
    {
        public void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            Console.WriteLine(imposto.Calcular(orcamento));
        }
    }
}
