using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Dispense_Mana_2
{
    delegate void overMaxEventHandler(object sender, OverMaxEventArgs e);
    class Counter
    {

        public event overMaxEventHandler OverMax;
        private int maxVal;
        public int cont = 0;
        public Counter(int n)
        {
            if (n > 10)
            {
                throw new ArgumentException("il valore massimo è 10");
            }
            else
            {
                maxVal = n;
            }
        }

        public void Increment()
        {
            cont++;
            if (cont >= maxVal)
            {
                OverMaxEventArgs e = new OverMaxEventArgs(cont);
                OnOverMax(this, e);
            }
        }

        private void OnOverMax(Counter sender, OverMaxEventArgs e)
        {
            if (OverMax != null) 
                OverMax(sender, e);
        }
    }
}
