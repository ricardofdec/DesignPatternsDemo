using DesignPatternsDemo.Interfaces;
using DesignPatternsDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class ISS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
