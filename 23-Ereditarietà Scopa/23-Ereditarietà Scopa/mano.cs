using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Ereditarietà_Scopa
{
    class mano
    {
        List<carta> man= new List<carta>();

        public mano()
        {
            man.Clear();
        }
        public List<carta> Lettura()
        {
            return man;
        }

        public carta Gioca(int indice)
        {
            carta aus = man.ElementAt(indice);
            man.RemoveAt(indice);
            return aus;
        }
    }
}
