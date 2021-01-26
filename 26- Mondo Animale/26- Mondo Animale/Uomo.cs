using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Mondo_Animale
{
    class Uomo : Bipede
    {
        public Uomo(String s) : base(s)
        {
            verso = "parla";
        }

        public override string chi_sei()
        {
            return "homo sapiens";
        }

        public override string vive()
        {
            return "in condominio";
        }
    }
}
