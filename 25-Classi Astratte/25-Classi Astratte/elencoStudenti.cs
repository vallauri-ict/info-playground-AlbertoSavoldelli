using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Classi_Astratte
{
    class elencoStudenti : report
    {
        List<studente> lststud = new List<studente>();
        public string stampa = "";
        protected override void printBody()
        {
            foreach (var item in lststud)
            {
                stampa += item.Nomecompleto() + "\n";
            }
        }
        protected override void printFooter()
        {
            stampa += "FOOTER\n";
        }
        protected override void printHeader()
        {
            stampa += "INTESTAZIONE\n";
        }
        public elencoStudenti()
        {
            lststud.Add(new studente("Andrea", "Galeazzi"));
            lststud.Add(new studente("Mauro", "Pippo"));
        }
    }
}
