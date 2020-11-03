using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Classe_Singleton
{
    class Singleton
    {
        public int val;
        private static Singleton instance = null;

        private Singleton()
        {
        }

        private Singleton(int val)
        {
            this.val = val;
        }

        public static Singleton GetSingleton(int valore)
        {
            if (instance == null)
            {
                instance = new Singleton(valore);
            }
            else
            {
                instance.val = valore;
            }
            return instance;
        }
    }
}
