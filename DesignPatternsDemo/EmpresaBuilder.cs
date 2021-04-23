using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class EmpresaBuilder
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public IList<EmpresaFilial> EmpresaFilial { get; set; } = new List<EmpresaFilial>();

        public void ComRazaoSocial(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
        }

        public void ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
        }

        public void AdicionarFilial(EmpresaFilial empresaFilial)
        {
            EmpresaFilial.Add(empresaFilial);
        }

        public Empresa Contruir()
        {
            return new Empresa(RazaoSocial, Cnpj, EmpresaFilial);
        }
    }
}
