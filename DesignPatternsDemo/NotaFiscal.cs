using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public IList<ItemNota> Itens { get; set; }
        public double Valor { get; set; }
        public NotaFiscal(String razaoSocial, String cnpj, IList<ItemNota> itens, double valor)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.Itens = itens;
            this.Valor = valor;
        }
    }
}
