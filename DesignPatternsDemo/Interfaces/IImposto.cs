using DesignPatternsDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Interfaces
{
    public interface IImposto
    {
        double Calcular(Orcamento orcamento);
    }
}
