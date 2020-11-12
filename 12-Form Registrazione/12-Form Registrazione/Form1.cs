using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Form_Registrazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true;
            Regex regCognome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (txtCognome.Text == "")
            {
                MessageBox.Show("Cognome non inserito!");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }
            else if (!regCognome.IsMatch(txtCognome.Text))
            {
                MessageBox.Show("Cognome non valido!");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }
            else
            {
                txtCognome.BackColor = Color.LightGreen;
            }


            Regex regNome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome non inserito!");
                valido = false;
                txtNome.BackColor = Color.Salmon;
            }
            else if (!regNome.IsMatch(txtNome.Text))
            {
                MessageBox.Show("Nome non valido!");
                valido = false;
                txtNome.BackColor = Color.Salmon;
            }
            else
            {
                txtNome.BackColor = Color.LightGreen;
            }

           
            Regex regIndirizzo = new Regex(@"^[A-Z]{1}[a-z]*\s*[A-Za-z]* \d{1,3}$");
            if (txtIndirizzo.Text == "")
            {
                MessageBox.Show("Indirizzo non inserito!");
                valido = false;
                txtIndirizzo.BackColor = Color.Salmon;
            }
            else if (!regIndirizzo.IsMatch(txtIndirizzo.Text))
            {
                MessageBox.Show("Indirizzo non valido!");
                valido = false;
                txtIndirizzo.BackColor = Color.Salmon;
            }
            else
            {
                txtIndirizzo.BackColor = Color.LightGreen;
            }

            
            Regex regCitta = new Regex(@"^[A-Z]{1}[a-z]*\s*[A-Z]*[a-z]*$");
            if (txtCittà.Text == "")
            {
                MessageBox.Show("Città non inserita!");
                valido = false;
                txtCittà.BackColor = Color.Salmon;
            }
            else if (!regCitta.IsMatch(txtCittà.Text))
            {
                MessageBox.Show("Città non valida!");
                valido = false;
                txtCittà.BackColor = Color.Salmon;
            }
            else
            {
                txtCittà.BackColor = Color.LightGreen;
            }

            
            Regex regCap = new Regex(@"^\d{5}$");
            if (txtCap.Text == "")
            {
                MessageBox.Show("CAP non inserito!");
                valido = false;
                txtCap.BackColor = Color.Salmon;
            }
            else if (!regCap.IsMatch(txtCap.Text))
            {
                MessageBox.Show("CAP non valido!");
                valido = false;
                txtCap.BackColor = Color.Salmon;
            }
            else
            {
                txtCap.BackColor = Color.LightGreen;
                // inserire nella classe Utente
            }

            // MAIL
            Regex regMail = new Regex(@"^[a-z]+[._-][a-z]+[.]*\d*[@][a-z]+[.][a-z]{2,4}$");
            if (txtMail.Text == "")
            {
                MessageBox.Show("Mail non inserita!");
                valido = false;
                txtMail.BackColor = Color.Salmon;
            }
            else if (!regMail.IsMatch(txtMail.Text))
            {
                MessageBox.Show("Mail inserita non valida!");
                valido = false;
                txtMail.BackColor = Color.Salmon;
            }
            else
            {
                txtMail.BackColor = Color.LightGreen;
                // inserire nella classe Utente
            }

            // CODICE FISCALE
            Regex regCodFisc = new Regex(@"^[A-Z]{6}\d{2}[A-Z]{1}\d{2}[A-Z]{1}\d{3}[A-Z]$");
            if (txtCodFisc.Text == "")
            {
                MessageBox.Show("Codice Fiscale non inserito!");
                valido = false;
                txtCodFisc.BackColor = Color.Salmon;
            }
            else if (!regCodFisc.IsMatch(txtCodFisc.Text))
            {
                MessageBox.Show("Codice Fiscale non valido!");
                valido = false;
                txtCodFisc.BackColor = Color.Salmon;
            }
            else
            {
                txtCodFisc.BackColor = Color.LightGreen;
                // inserire nella classe Utente
            }

            // USER
            Regex regUser = new Regex(@"^\w{8,}$");
            if (txtUser.Text == "")
            {
                MessageBox.Show("Username non inserito!");
                valido = false;
                txtUser.BackColor = Color.Salmon;
            }
            else if (!regUser.IsMatch(txtUser.Text))
            {
                MessageBox.Show("Username non valido!");
                valido = false;
                txtUser.BackColor = Color.Salmon;
            }
            else
            {
                txtUser.BackColor = Color.LightGreen;
                // inserire nella classe Utente
            }

            // PASSWORD
            Regex regPw = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}$");
            if (txtPw.Text == "")
            {
                MessageBox.Show("Password non inserita!");
                valido = false;
                txtPw.BackColor = Color.Salmon;
            }
            else if (!regPw.IsMatch(txtPw.Text))
            {
                MessageBox.Show("Password non valida!");
                valido = false;
                txtPw.BackColor = Color.Salmon;
            }
            else
            {
                txtPw.BackColor = Color.LightGreen;
                // inserire nella classe Utente
            }

            if (valido)
            {
                Utente u = Utente.GetClsSingleton();
                if (u.presente(txtCognome.Text, txtNome.Text, txtIndirizzo.Text, txtCittà.Text, txtCap.Text, txtMail.Text, txtCodFisc.Text, txtUser.Text, txtPw.Text) == false)
                {
                    txtUser.BackColor = Color.LightGreen;
                    MessageBox.Show("Utente aggiunto");
                    txtCognome.BackColor = Color.White;
                    txtNome.BackColor = Color.White;
                    txtIndirizzo.BackColor = Color.White;
                    txtCittà.BackColor = Color.White;
                    txtCap.BackColor = Color.White;
                    txtMail.BackColor = Color.White;
                    txtCodFisc.BackColor = Color.White;
                    txtUser.BackColor = Color.White;
                    txtPw.BackColor = Color.White;
                }
                else
                {
                    txtUser.BackColor = Color.Red;
                    MessageBox.Show("Nome utente già inserito");
                }
            }
            else
            {
                MessageBox.Show("Registrazione fallita");
            }
    }
    }
}
