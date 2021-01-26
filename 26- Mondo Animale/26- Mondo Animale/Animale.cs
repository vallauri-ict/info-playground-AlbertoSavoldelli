using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Mondo_Animale
{
    abstract class Animale
    {
        protected String nome;
        protected String verso;

        public Animale(String s)
        {
            nome = s;
        }

        public abstract String si_muove();

        public abstract String vive();

        public abstract String chi_sei();

        public void mostra()
        {
            Console.WriteLine(nome + ", " + chi_sei() + ", " + verso + ", si muove " + si_muove() + " e vive " + vive());
        }
    }
}
