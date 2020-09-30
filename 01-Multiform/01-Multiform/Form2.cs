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
    public partial class Form2 : Form
    {
        private int n;
        private TextBox txt1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }
        public Form2(TextBox txt1)
        {
            InitializeComponent();
            this.txt1 = txt1;
        }

        private void btnLeggiValore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore: "+n);
        }

        private void btnValoreTxt_Click(object sender, EventArgs e)
        {
            txt1.Text = txtForm2.Text;
        }

        private void btnApriFormFiglia_Click(object sender, EventArgs e)
        {
            Form f = new FormFiglia();
            this.AddOwnedForm(f);
            f.Show();
        }
    }
}
