using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Classi_Astratte
{
    class studente
    {
        private string Nome { get; set; }

        private string Cognome { get; set; }

        private DateTime datanascita;
        public studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
        public string Nomecompleto()
        {
            return Nome + " " + Cognome;
        }
    }
}
