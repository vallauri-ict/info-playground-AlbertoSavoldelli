using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24__Carte_2
{
    public partial class Form1 : Form
    {
        mazzoCarte mazzo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if (txtSeme.Text != "" && txtValore.Text != "")
            {
                try
                {
                    mazzo.inserisci(txtValore.Text, txtSeme.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("MANCANO DEI DATI");
        }

        private void btnDammi_Click(object sender, EventArgs e)
        {
            mazzo.Mescola();
            carte aus = mazzo.dammi();
            MessageBox.Show(aus.Valore + " di " + aus.Seme);
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (txtSeme.Text != "" && txtValore.Text != "")
            {
                pos = mazzo.dammi(txtValore.Text, txtSeme.Text);
            }
            else
                MessageBox.Show("MANCANO DEI DATI");
            if (pos == -1)
            {
                MessageBox.Show("CARTA NON PRESENTE NEL MAZZO");
            }
            else
                MessageBox.Show("POSIZIONE: " + pos);
        }
    }
}
