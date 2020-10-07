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
    public partial class FormModale : Form
    {
        public string nome = "";
        public string eta = "";
        public FormModale()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            eta = txtEta.Text;
            MessageBox.Show("Premuto ok");
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEta.Text = "";
            MessageBox.Show("Premuto annulla!");
        }
    }
}
