using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_Ereditarietà_es_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mannaro x = new Mannaro();
            Mostro y;
            y = ClonaV(x);
            x.Rivela();
            y.Rivela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro();
            Mostro y;
            y = ClonaR(ref x);
            x.Rivela();
            y.Rivela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro();
            Mostro y;
            y = ClonaO(out x);
            x.Rivela();
            y.Rivela();
        }
        public Mostro ClonaV(Mostro p)
        {
            p = new Mostro("Valuex");
            p.nome = "Cambia";
            return p;
        }
        public Mostro ClonaR(ref Mostro p)
        {
            p = new Mostro("Referex");
            p.nome = "Cambia";
            return p;
        }
        public Mostro ClonaO(out Mostro p)
        {
            p = new Mostro("Resulx");
            p.nome = "Cambia";
            return p;
        }
    }
}
