using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_Interfaccia_Comparabile
{
    public partial class btnOrdinaMostra : Form
    {
        Persona[] vect = {
            new Persona("Antonio","Bonelli","Alba"),
            new Persona("Samuele","Stefirca","Savigliano"),
            new Persona("Luca","Ariaudo","Fossano")};

                        
                        
        public btnOrdinaMostra()
        {
            InitializeComponent();
            ShowPerson();
        }
        public void ShowPerson()
        {
            string s = "";
            foreach (var item in vect)
            {
                s += item.ToString() + "\n";
            }
            MessageBox.Show(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Sort(vect);
            ShowPerson();
        }
    }
}
