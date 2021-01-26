using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Mondo_Animale
{
    class Tonno : AnimaleMarino
    {
        public Tonno(String s) : base(s)
        {
            verso = "non fa versi";
        }

        public override string chi_sei()
        {
            return "tonno";
        }

        public override string si_muove()
        {
            return "nuotando";
        }
    }
}
