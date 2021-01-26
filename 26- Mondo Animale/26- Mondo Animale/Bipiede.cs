using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Mondo_Animale
{
    abstract class Bipede : AnimaleTerrestre
    {
        public Bipede(String s) : base(s)
        {

        }

        public override String si_muove()
        {
            return " su 2 gambe";
        }
    }
}
