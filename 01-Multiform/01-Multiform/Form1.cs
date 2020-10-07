using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Multiform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnApriForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Senza Parametro";
            f2.Show();
            Form f2p = new Form2(10);
            f2p.Text = "Con parametro";
            f2p.Show();

        }

        private void BtnForm2_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text = "Aperta form dinamica";
            f2b.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPassaTxt_Click(object sender, EventArgs e)
        {
            Form f2b = new Form2(txtPassata);
            f2b.Text = "Con parametro";
            f2b.Show();

        }

        private void btnFormModale_Click(object sender, EventArgs e)
        {
            FormModale fm = new FormModale();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                txtNomefm.Text = fm.nome;
                txtEtafm.Text = fm.eta;
                MessageBox.Show("Premuto ok");
            }
            else
                MessageBox.Show("Premuto annulla");
        }
    }
}
