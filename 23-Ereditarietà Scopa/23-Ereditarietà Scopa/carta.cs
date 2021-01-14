using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Ereditarietà_Scopa
{
    class carta
    {
        private string seme;
        private int valore;

        public carta(string seme, int valore)
        {
            this.seme = seme;
            this.valore = valore;
        }
        public void Lettura(out string seme, out int valore)
        {
            seme = this.seme;
            valore = this.valore;
        }
    }
}
