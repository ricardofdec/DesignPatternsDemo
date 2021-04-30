using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.Valor * this.Fator);
        }
    }
}
