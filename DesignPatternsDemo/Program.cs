using DesignPatternsDemo.Interfaces;
using DesignPatternsDemo.Models;
using System;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainOfResponsibility();

            Console.ReadKey();
        }

        private static void EmpresaBuilder()
        {
            EmpresaBuilder criarEmpresa = new EmpresaBuilder();
            criarEmpresa.ComCnpj("123.456.789/0001-12");
            criarEmpresa.ComRazaoSocial("Mad Tech");
            criarEmpresa.AdicionarFilial(new EmpresaFilial("Empresa F1", 100000.00));
            criarEmpresa.AdicionarFilial(new EmpresaFilial("Empresa F2", 100000.00));
            var empresa = criarEmpresa.Contruir();
            Console.WriteLine(empresa.RazaoSocial);
            Console.WriteLine(empresa.Cnpj);

            foreach (var item in empresa.Itens)
            {
                Console.WriteLine($"Empresa Filial: {item.Nome}");
            }
        }

        public static void ChainOfResponsibility()
        {
            Orcamento orcamento = new Orcamento(500);
            orcamento.Itens.Add(new Item("Iphone 12", 6500.00));

            CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();


            Console.WriteLine($"Desconto é de :{calculadorDeDescontos.Calcula(orcamento)}");
        }

        private static void Strategy_Investimento()
        {
            var context = new RealizadorDeInvestimentos();

            context.Investir(new CONSERVADOR());
            Console.WriteLine($"CONSERVADOR: {context.Calcular(20)}");

            context.Investir(new MODERADO());
            Console.WriteLine($"MODERADO: {context.Calcular(32)}");

            context.Investir(new ARROJADO());
            Console.WriteLine($"ARROJADO: {context.Calcular(68)}");
        }


        private static void Strategy()
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();

            calculadorDeImpostos.RealizarCalculo(orcamento, iss);
            calculadorDeImpostos.RealizarCalculo(orcamento, icms);
            calculadorDeImpostos.RealizarCalculo(orcamento, iccc);
        }
    }
}
