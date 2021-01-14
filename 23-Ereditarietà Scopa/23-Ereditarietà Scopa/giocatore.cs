using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Ereditarietà_Scopa
{
    class giocatore
    {
        private string nome;
        mano man;
        List<carta> prese = new List<carta>();

        public giocatore(string nome)
        {
            this.nome = nome;
            man = new mano();
            prese.Clear();
        }
        public mano Lettura()
        {
            return man;
        }

        public List<carta> Prese()
        {
            return prese;
        }

        public void Gioca(int indice)
        {
            carta giocata = man.Gioca(indice);
        }
    }
}
