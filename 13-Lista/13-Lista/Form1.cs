using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Libro
        {
            public int id;
            public string titolo;
            public string autore;
        }

        List<Libro> myList = new List<Libro>();
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Libro l;

            l.id = Convert.ToInt32(txtID.Text);
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;

            myList.Add(l);
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            foreach (var libro in myList)
            {
                MessageBox.Show("Titolo: " + libro.titolo + "\nAutore: " + libro.autore);
            }
        }
    }
}
