using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo    
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("salvando no banco");
        }
    }
}
