using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Gestione_Container
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Container
        {
            public string cod;
            public int peso;
            public int tara;
        }

        Stack<Container> container = new Stack<Container>();
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if (txtTara.Text != "" && txtPeso.Text != "" && txtCodice.Text != "")
            {
                Container c;
                c.cod = txtCodice.Text;
                c.peso = Convert.ToInt32(txtPeso.Text);
                c.tara = Convert.ToInt32(txtTara.Text);
                container.Push(c);
                MessageBox.Show("CONTAINER AGGIUNTO");
            }
            else
            {
                MessageBox.Show("NON AGGIUNTO");
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                Container c = container.Pop();
                MessageBox.Show("CONTAINER CARICATO NELLA STIVA: \n" + c.cod + "\n" + c.peso + "\n" + c.tara);
            }
            catch (Exception)
            {
                MessageBox.Show("NESSUN CONTAINER IN PORTO");
            }
        }
    }
}
