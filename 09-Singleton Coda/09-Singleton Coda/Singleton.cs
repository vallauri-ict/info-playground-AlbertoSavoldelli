using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Singleton_Coda
{
    class Singleton
    {
        private static Singleton istanza = null;
        public static Queue<string> codaStampa = new Queue<string>();

        private Singleton()
        {

        }

        public void push(string s)
        {
            codaStampa.Enqueue(s);
            MessageBox.Show(s + " aggiunto alla coda");
        }

        public void pull()
        {
            try
            {
                string s = codaStampa.Dequeue();
                MessageBox.Show(s);
            }
            catch (Exception)
            {
                MessageBox.Show("Coda vuota");
            }
        }

        public static Singleton GetClsSingleton()
        {
            if (istanza == null)
            {
                istanza = new Singleton();
            }
            return istanza;
        }
    }
}
