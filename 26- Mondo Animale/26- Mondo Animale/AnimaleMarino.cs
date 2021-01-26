using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Mondo_Animale
{
    abstract class AnimaleMarino : AnimaleAcquatico
    {
        public AnimaleMarino(String s) : base(s)
        {

        }

        public override String vive()
        {
            return "in mare";
        }

        public override String chi_sei()
        {
            return "un animale marino";
        }
    }
}
