using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Mondo_Animale
{
    class Corvo : Uccello
    {
        public Corvo(String s) : base(s)
        {
            verso = "gracchia";
        }

        public override string chi_sei()
        {
            return "corvo";
        }
    }
}
