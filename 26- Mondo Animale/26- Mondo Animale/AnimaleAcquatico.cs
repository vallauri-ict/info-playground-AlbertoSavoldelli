using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Mondo_Animale
{
    abstract class AnimaleAcquatico : Animale
    {
        public AnimaleAcquatico(String s) : base(s)
        {

        }

        public override String vive()
        {
            return "nell'acqua";
        }

        public override String chi_sei()
        {
            return "un animale acquatico";
        }
    }
}
