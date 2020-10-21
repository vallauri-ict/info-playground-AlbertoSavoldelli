using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Programmazione_a_oggetti
{
    class rectangle
    {
        private int side1, side2;
        public Color colore;

        public rectangle(int b,int h)
        {
            side1 = b;
            side2 = h;
        }

        public string getSide()
        {
            return "BASE:"+side1.ToString() + " ALTEZZA" + side2.ToString();
        }
    }
}
