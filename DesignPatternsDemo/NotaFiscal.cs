using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemNota> Itens { get; set; }
        public String Observacao { get; set; }

        public NotaFiscal(String razaoSocial, String cnpj, DateTime dataEmissao,
            double valorBruto, double impostos, IList<ItemNota> itens, String observacao)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataEmissao = dataEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacao = observacao;
        }
    }
}
