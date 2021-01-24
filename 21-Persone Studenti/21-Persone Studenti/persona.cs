using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Persone_Studenti
{
    class persona
    {
        string nome;
        string cognome;
        string sesso;
        private int eta;

        public string GetNome()
        {
            return this.nome;
        }

        public string GetCognome()
        {
            return this.cognome;
        }

        public string GetSesso()
        {
            return this.sesso;
        }

        public int GetEta()
        {
            return this.eta;
        }
        public void setAttributes(string nome, string cognome, string sesso, int eta)
        {
            if (nome != "" && cognome != "" && sesso != "" && eta != 0)
            {
                this.nome = nome;
                this.cognome = cognome;
                this.sesso = sesso;
                this.eta = eta;
            }
        }
    }
}
