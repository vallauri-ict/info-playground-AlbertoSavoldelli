using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24__Carte_2
{
    class carte
    {
        private string seme;
        private string valore;
        public string[] val = { "Asso", "2", "3", "4", "5", "6", "7", "Fante", "Regina", "Re" };
        public string[] semi = { "Cuori", "Quadri", "Picche", "Fiori" };
        public carte(string valore, string seme)
        {
            Valore = valore;
            Seme = seme;
        }
        public carte()
        {

        }

        public string Seme
        {
            get => seme;
            set => seme = value;
        }
        public string Valore
        {
            get => valore;
            set => valore = value;
        }

        
    }
}
