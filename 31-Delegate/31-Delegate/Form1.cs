using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate int Operazione(int a, int b);
        public int Somma(int x, int y)
        {
            return x + y;
        }
        public int Sottrazione(int x, int y)
        {
            return x - y;
        }
        public int Prodotto(int x, int y)
        {
            return x * y;
        }
        private void btnpiu_Click(object sender, EventArgs e)
        {
            Operazione op = new Operazione(Somma);
            MessageBox.Show("Somma = " + op(10, 15));
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            Operazione op = Prodotto;
            MessageBox.Show("Prodotto = " + op(10, 15));
        }

        private void btnMeno_Click(object sender, EventArgs e)
        {
            Operazione op = Sottrazione;
            MessageBox.Show("Differenza = " + dif(15, 10, op).ToString());
        }
        private int dif(int a, int b, Operazione op)
        {
            if (a >= b)
            {
                return op(a, b);
            }
            else
            {
                return op(b, a);
            }
        }
    }
}
