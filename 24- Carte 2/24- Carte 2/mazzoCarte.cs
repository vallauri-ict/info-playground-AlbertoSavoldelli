using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24__Carte_2
{
    class mazzoCarte
    {
        Random rnd = new Random();
        private int progr = 0;
        private List<carte> mazzo = new List<carte>();

        public mazzoCarte()
        {
            carte aus = new carte();
            foreach (var seme in aus.semi)
            {
                foreach (var valore in aus.val)
                {
                    carte carta = new carte(valore, seme);
                    mazzo.Add(carta);
                }
            }
        }

        public void inserisci(string valore, string seme)
        {
            carte carta = new carte();
            carta.Seme = seme;
            carta.Valore = valore;
            if (mazzo.Find(bf => bf.Valore == valore && bf.Seme == seme) == null)
            {
                mazzo.Add(carta);
                System.Windows.Forms.MessageBox.Show("INSERITA CORRETTAMENTE");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("GIA PRESENTE");
            }
        }

        public carte dammi()
        {
            carte aus = mazzo.First();
            mazzo.RemoveAt(0);
            return aus;
        }

        public int dammi(string valore, string seme)
        {
            carte aus = mazzo.Find(bf => bf.Valore == valore && bf.Seme == seme);
            return mazzo.IndexOf(aus);
        }

        public void Mescola()
        {
            carte app;
            int length = mazzo.Count;
            for (int i = 0; i < length; i++)
            {
                app = mazzo.First();
                mazzo.Remove(mazzo.First());
                mazzo.Insert(rnd.Next(1, length), app);
            }
        }
    }
}
