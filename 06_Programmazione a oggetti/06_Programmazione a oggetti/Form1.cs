using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Programmazione_a_oggetti
{
    public partial class Form1 : Form
    {
        rectangle r;
        public Form1()
        {
            InitializeComponent();
            r = new rectangle(1,1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            //r.side1 = Convert.ToInt32(txtBase.Text);
            //r.side2 = Convert.ToInt32(txtAltezza.Text);
            //rectangle t;
            //t = r;
            //MessageBox.Show("Base: "+r.side1+"\nAltezza: "+r.side2);
            //t.side1 = 6;
            //MessageBox.Show("OGGETTO r DOPO MODIFICHE SU t\nBase: " + t.side1 + "\nAltezza: " + t.side2);
            r.colore = Color.White;
            MessageBox.Show(r.getSide());
            rectangle r1 = new rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(r1.getSide());
        }
    }
}
