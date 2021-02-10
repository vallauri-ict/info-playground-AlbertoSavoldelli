using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_026_EsercizioStagisti
{
    public partial class Form1 : Form
    {
        private ClsElenco elencoStudenti;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elencoStudenti = new ClsElenco();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            ClsAlunno stu;
            if (txtOre.Text.Trim() == "")
            {
                stu = new ClsAlunno(txtNome.Text, txtCognome.Text, txtCitta.Text, cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString());
            }
            else
            {
                stu = new ClsStagista(txtNome.Text, txtCognome.Text, txtCitta.Text, cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString());
                btnRicerca.Enabled = true;
            }
            elencoStudenti.inserisci(stu);
            elencoStudenti.visalizzaDGV(dgvStudenti);
            pulisciCampi();
        }

        private void pulisciCampi()
        {
            foreach(Control t in Controls)
            {
                if(t is TextBox)
                {
                    ((TextBox)t).Text = "";
                }

                if(t is ComboBox)
                {
                    ((ComboBox)t).SelectedIndex = 0;
                }
            }
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string azienda = cmbAzienda.SelectedItem.ToString();
            int ore = elencoStudenti.OreAzienda(azienda);
            if (ore != 0)
            {
                MessageBox.Show("Gli stagisti hanno effettuato "+ore+" ore in "+azienda,"information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Non è stata effettuata alcuna ora in " + azienda, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (numPosElimina.Text == "")
                    elencoStudenti.cancella();
                else
                    elencoStudenti.cancella(Convert.ToInt32(numPosElimina.Text));
                MessageBox.Show("Cancellazione effettuata!");
                elencoStudenti.visalizzaDGV(dgvStudenti);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
