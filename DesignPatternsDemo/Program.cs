using DesignPatternsDemo.Interfaces;
using DesignPatternsDemo.Models;
using System;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }


        private static void Strategy()
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();

            calculadorDeImpostos.RealizarCalculo(orcamento, iss);
            calculadorDeImpostos.RealizarCalculo(orcamento, icms);
            calculadorDeImpostos.RealizarCalculo(orcamento, iccc);
        }
    }
}
