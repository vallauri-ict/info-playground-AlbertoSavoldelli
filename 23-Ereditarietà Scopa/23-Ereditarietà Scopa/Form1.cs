using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_Ereditarietà_Scopa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        mazzo mazz;

        private void btnGenera_Click(object sender, EventArgs e)
        {
            mazz = new mazzo();
        }

        private void btnMischia_Click(object sender, EventArgs e)
        {
            string seme;
            int val;
            mazz.Mescola();
            carta aus = mazz.Estrai();
            aus.Lettura(out seme, out val);
            MessageBox.Show(val + " di " + seme);
        }
    }
}
