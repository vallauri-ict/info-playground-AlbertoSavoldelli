using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_026_EsercizioStagisti
{
    sealed class ClsElenco
    {
        List<ClsAlunno> elenco;

        public ClsElenco()
        {
            elenco = new List<ClsAlunno>();
        }
        public void inserisci(ClsAlunno a)
        {
            elenco.Add(a);

        }
        public void visalizzaDGV(DataGridView dgv)
        {
            dgv.DataSource = typeof(List<>);
            dgv.DataSource = elenco;
        }
        public int OreAzienda(string nomeA)
        {
            int oreTotAzienda = 0;

            foreach(ClsAlunno a in elenco)
            {
                if(a is ClsStagista)
                {
                    ClsStagista s = a as ClsStagista;
                    if (s.Azienda == nomeA)
                    {
                        oreTotAzienda += Convert.ToInt32(s.Ore);
                    }
                }
            }
            return oreTotAzienda;
        }
        public void cancella()
        {
            if (elenco.Count == 0)
                throw new Exception("Cancellazione negata, lista vuota");
            else
                elenco.RemoveAt(elenco.Count - 1);
        }
        public void cancella(int posizione)
        {
            if (elenco.Count == 0)
            {
                throw new Exception("Cancellazione negata, lista vuota");
            }
            else if (posizione < 0 || posizione > elenco.Count - 1)
                throw new Exception("Posizione non valida");
            else
                elenco.RemoveAt(posizione);
        }
    }
}
