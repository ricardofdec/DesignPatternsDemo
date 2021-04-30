using DesignPatternsDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Interfaces
{
    public interface Desconto
    {
        double Desconto(Orcamento orcamento);
        Desconto Proximo { get; set; }
    }
}
