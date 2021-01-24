using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22__Complessi_Quaternoni
{
    class complesso
    {
        protected double reale;
        protected double immaginario;

        public complesso()
        {
            this.reale = 0;
            this.immaginario = 0;
        }

        public complesso(double reale, double immaginario)
        {
            this.reale = reale;
            this.immaginario = immaginario;
        }

        public complesso(double reale)
        {
            this.reale = reale;
            this.immaginario = 0;
        }

        public void GetAttributes(out double reale, out double immaginario)
        {
            reale = this.reale;
            immaginario = this.immaginario;
        }
        public double GetReale()
        {
            return this.reale;
        }
        public double GetImmaginario()
        {
            return this.immaginario;
        }

        public double Modulo()
        {
            double reale, immaginario;
            GetAttributes(out reale, out immaginario);
            double somma = Math.Pow(reale, 2) + Math.Pow(immaginario, 2);
            return Math.Sqrt(somma);
        }

        public double Coniugato()
        {
            double coniugato = -GetImmaginario();
            return coniugato;
        }
    }
}
