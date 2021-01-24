using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_Persone_Studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<studente> lstStudenti = new List<studente>();
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            studente s = new studente();
            if (txtNome.Text != "" && txtSesso.Text != "" && txtCognome.Text != ""&& txtEta.Text != "")
            {
                s.setAttributes(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
                lstStudenti.Add(s);
                listStudenti.Items.Add(s.GetCognome());
                MessageBox.Show("RIUSCITO");
            }
            else
            {
                MessageBox.Show("INSERIRE TUTTI I DATI");
            }
        }

        private void btnVoto_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text != "")
            {
                foreach (studente item in lstStudenti)
                {
                    if (item.GetCognome() == listStudenti.SelectedItems[0].Text)
                    {
                        item.voti.Add(Convert.ToInt32(txtVoto.Text));
                    }
                }
                MessageBox.Show("AGGIUNTO");
            }
            else
                MessageBox.Show("INSERIRE IL VOTO");
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            studente s = new studente();
            s = lstStudenti.Find(stud => stud.GetCognome() == listStudenti.SelectedItems[0].Text);
            MessageBox.Show(s.GetCognome() + " ha la media pari a " + s.Media());
        }
    }
}
