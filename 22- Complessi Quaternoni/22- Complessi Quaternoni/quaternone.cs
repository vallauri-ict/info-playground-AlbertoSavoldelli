using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22__Complessi_Quaternoni
{
    class quaternone : complesso
    {
        private double immaginarioJ;
        private double immaginarioK;

        public quaternone() : base()
        {

        }

        public void GetAttributes(double reale, double immaginario, double immaginarioJ, double immaginarioK)
        {
            reale = this.reale;
            immaginario = this.immaginario;
            immaginarioJ = this.immaginarioJ;
            immaginarioK = this.immaginarioK;
        }
    }
}
