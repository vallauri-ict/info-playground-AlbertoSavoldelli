using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Negozio_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct book
        {
            public int key;
            public string value;
        }
        Dictionary<int, book> diz = new Dictionary<int, book>();

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            book b;
            b.key = Convert.ToInt32(txtKey.Text);
            b.value = txtValue.Text;
            diz.Add(Convert.ToInt32(txtKey.Text), b);
            MessageBox.Show("INSERIMENTO EFFETTUATO");
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lblNum.Text = "NUMERO ELEMENTI:" + diz.Count;
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(Interaction.InputBox("INSERISCI LA CHIAVE DELL'ARTICOLO DA CERCARE: ", "ARTICOLO DA CERCARE"));
            lblArt.Text = "NOME ARTICOLO CERCATO: " + diz[k].value;
        }
    }
}
