using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Mondo_Animale
{
    class Pinguino : Uccello
    {
        public Pinguino(String s) : base(s)
        {
            verso = "non fa versi";
        }

        public override string chi_sei()
        {
            return "pinguino";
        }

        public override string si_muove()
        {
            return "ma non sa volare";
        }
    }
}
