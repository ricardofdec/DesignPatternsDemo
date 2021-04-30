using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public IList<ItemNota> NotaFiscalItem { get; set; } = new List<ItemNota>();
        public DateTime Date { get; set; }

        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas;
        public Multiplicador Multiplicador { get; set; }
        public NotaFiscalBuilder()
        {
            this.todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();
        }

        public void ComRazaoSocial(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
        }

        public void Com(String cnpj)
        {
            this.Cnpj = cnpj;
        }

        public void Com(ItemNota empresaFilial)
        {
            NotaFiscalItem.Add(empresaFilial);
        }

        public NotaFiscal Contruir()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, NotaFiscalItem);
        }

        public void addData(DateTime dateTime)
        {
            this.Date = dateTime;
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }

    }
}
