using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _11_Regex_Compito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnControllaTarga_Click(object sender, EventArgs e)
        {
            Regex rgxTarga = new Regex("^[A-Z]{2}[0-9]{3}[A-Z]{2}$");
            if (txtTarga.Text != "")
            {
                if (rgxTarga.IsMatch(txtTarga.Text))
                {
                    MessageBox.Show("TARGA OK");
                    txtTarga.Text = "";
                }
                else
                {
                    MessageBox.Show("TARGA NON CORRETTA");
                    txtTarga.Text = "";
                    txtTarga.Focus();
                }
            }
            else
            {
                MessageBox.Show("IL CAMPO TARGA NON RISULTA COMPLIATO!!");
            }
        }

        private void btnControllaPassword_Click(object sender, EventArgs e)
        {
            Regex rgxPassword = new Regex("^[a-zA-Z]{8}\\d{3}[-?@]$");
            if (txtPassword.Text != "")
            {
                if (rgxPassword.IsMatch(txtPassword.Text))
                {
                    MessageBox.Show("PASSWORD OK");
                    txtPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("PASSWORD NON ACCETTATA");
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("IL CAMPO PASSWORD NON RISULTA COMPILATO!!");
            }
        }
    }
}
