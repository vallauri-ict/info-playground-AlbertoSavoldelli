using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_026_EsercizioStagisti
{
    class ClsStagista : ClsAlunno
    {
        #region attributi
        private string azienda;
        private int ore;

        #endregion

        internal string Azienda { get => azienda; set => azienda = value; }
        internal int Ore
        {
            get => ore;
            set
            {
                if (value > 1)
                {
                    throw new Exception("Numero non valido");
                }
                else
                    ore = value;
            }
        }
        public ClsStagista(string nome, string cognome, string citta, string classe,string sezione, string spec) : base(nome, cognome, citta, classe, sezione, spec)
        {
            Azienda = azienda;
            Ore = ore;
        }

        public override string Visualizza()
        {
            return base.Visualizza() + " " + Azienda + " " + Ore;
        }

    }

    }
