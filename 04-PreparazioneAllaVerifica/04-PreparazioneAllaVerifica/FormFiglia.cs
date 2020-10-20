using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_PreparazioneAllaVerifica
{
    public partial class FormFiglia : Form
    {
        private string txt;
        private TextBox txtPadre;
        public FormFiglia(TextBox txtPadre)
        {
            InitializeComponent();
            this.txtPadre = txtPadre;
        }

        public string TxtValue
        {
            get => txt;
            set
            {
                txt = value;
                txtStringaFiglia.Text = txt;
            }
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            txtPadre.Text = txtStringaFiglia.Text;
        }
        private void FormFiglia_Load(object sender, EventArgs e)
        {

        }

    }
}
