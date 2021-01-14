using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Ereditarietà_Scopa
{
    class mazzo
    {
        List<carta> mazz = new List<carta>();
        Random rnd = new Random();

        public mazzo()
        {
            for (int i = 1; i < 11; i++)
            {
                carta card = new carta("Denari", i);
                mazz.Add(card);
            }
            for (int i = 1; i < 11; i++)
            {
                carta card = new carta("Bastoni", i);
                mazz.Add(card);
            }
            for (int i = 1; i < 11; i++)
            {
                carta card = new carta("Spade", i);
                mazz.Add(card);
            }
            for (int i = 1; i < 11; i++)
            {
                carta card = new carta("Coppe", i);
                mazz.Add(card);
            }
        }
        public void Mescola()
        {
            carta aus;
            int l = mazz.Count;
            for (int i = 0; i < l; i++)
            {
                aus = mazz.First();
                mazz.Remove(mazz.First());
                mazz.Insert(rnd.Next(1, l), aus);
            }
        }
        public carta Estrai()
        {
            carta aus = mazz.First();
            mazz.RemoveAt(0);
            return aus;
        }
    }
}
