using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    public class RealizadorDeInvestimentos
    {
        private IStrategy _strategy;

        public RealizadorDeInvestimentos()
        { }

        public RealizadorDeInvestimentos(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void Investir(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public double Calcular(int chance)
        {
            return this._strategy.Calcular(chance);
        }
    }

    public interface IStrategy
    {
        double Calcular(int chance);
    }

    class CONSERVADOR : IStrategy
    {
        public double Calcular(int chance)
        {
            return 0.8;
        }
    }

    class MODERADO : IStrategy
    {
        public double Calcular(int chance)
        {
            return chance == 50 ? 2.5 : 0.7;
        }
    }

    class ARROJADO : IStrategy
    {
        public double Calcular(int chance)
        {
            if (chance <= 0)
            {
                return 0.5;
            }
            else if (chance <= 30 && chance <= 50)
            {
                return 3;
            }
            else if (chance > 50)
            {
                return 0.6;
            }

            return 0;
        }
    }
}
