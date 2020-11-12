using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Form_Registrazione
{
    class Utente
    {
        private static Utente istanza = null;
        public static Queue<string> codaUtenti = new Queue<string>();
        private readonly string nomeFile = "Utenti.txt";
        public static Utente GetClsSingleton()
        {
            if (istanza == null)
            {
                istanza = new Utente();
            }
            return istanza;
        }

        internal bool presente(string Cognome, string Nome, string Indirizzo, string Città, string Cap, string Mail, string CodFisc, string User, string Pw)
        {
            if (codaUtenti.Contains(User))
            {
                return true;
            }
            else
            {
                codaUtenti.Enqueue(User);
                StreamWriter sw = new StreamWriter(nomeFile, true);
                sw.WriteLine(Cognome + " " + Nome + " " + Indirizzo + " " + Città + " " + Cap + " " + Mail + " " + CodFisc + " " + User + " " + Pw);
                sw.Close();
                return false;
            }
        }
    }
}
