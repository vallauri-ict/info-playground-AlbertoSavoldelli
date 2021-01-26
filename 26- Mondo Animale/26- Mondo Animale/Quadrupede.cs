using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Mondo_Animale
{
    abstract class Quadrupede : AnimaleTerrestre
    {
        public Quadrupede(String s) : base(s)
        {

        }

        public override String si_muove()
        {
            return "avanzando su 4 zampe";
        }
    }
}
