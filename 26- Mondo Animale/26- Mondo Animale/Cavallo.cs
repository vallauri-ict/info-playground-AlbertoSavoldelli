using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Mondo_Animale
{
    class Cavallo : Quadrupede
    {
        public Cavallo(String s) : base(s)
        {
            verso = "nitrisce";
        }

        public override string chi_sei()
        {
            return "cavallo";
        }
    }
}
