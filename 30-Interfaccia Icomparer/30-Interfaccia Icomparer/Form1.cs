using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_Interfaccia_Icomparer
{
    public partial class Form1 : Form
    {
        Persona[] vet = { new Persona("Luca", "Ariaudo", "Fossano"),
                        new Persona("Antonio", "Bonelli", "Alba"),
                        new Persona("Samuele", "Stefirca", "Savigliano")
    };

        public Form1()
        {
            InitializeComponent();
        }
        public void showPersona()
        {
            string s = "";
            foreach (var item in vet)
            {
                s += item.ToString() + "\n";
            }
            MessageBox.Show(s);
        }

        private void btnOrdinaCognome_Click(object sender, EventArgs e)
        {
            Array.Sort(vet, new Persona.ConfrontaCognome());
            showPersona();
        }

        private void btnOrdinaNome_Click(object sender, EventArgs e)
        {
            Array.Sort(vet, new Persona.ConfrontaNome());
            showPersona();
        }
        }
}
