using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class Empresa
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public IList<EmpresaFilial> Itens { get; set; }

        public Empresa(String razaoSocial, String cnpj, IList<EmpresaFilial> itens)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.Itens = itens;
        }
    }
}
