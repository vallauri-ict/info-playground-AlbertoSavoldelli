using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Classi_Astratte
{
    abstract class report
    {
        protected abstract void printHeader();
        protected abstract void printBody();
        protected abstract void printFooter();
        public void print()
        {
            printHeader();
            printBody();
            printFooter();
        }
    }
}
