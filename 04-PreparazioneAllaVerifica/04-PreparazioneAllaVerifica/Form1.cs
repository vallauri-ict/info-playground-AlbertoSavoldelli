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
    public partial class Form1 : Form
    {
        public FormFiglia ff;
        public bool isInviaPremuto = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txtNome, txtEta);
            if (f2.ShowDialog() == DialogResult.OK)//showDialog aspetta finisca f2
            {
                MessageBox.Show("Nome:" + f2.nome + "\nEtà:" + f2.eta);
                txtEta.Text = f2.eta;
                txtNome.Text = f2.nome;
                toolStripStatusLabel1.Text = "File/ApriForm2/Ok";
            }
            else
            {
                MessageBox.Show("Operazione annullata");
                toolStripStatusLabel1.Text = "File/ApriForm2/Annulla";
            }

        }

        private void formDinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fd = new Form();
            fd.Show();
            fd.Text = "Form Dinamica";
            toolStripStatusLabel1.Text = "File/ApriFormDinamica";

        }

        private void formFIgliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ff = new FormFiglia(txtStringa);
            this.AddOwnedForm(ff);
            ff.Show();
            toolStripStatusLabel1.Text = "File/ApriFormFiglia";
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            ff.TxtValue= txtStringa.Text;
        }

        private void formMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMdiParent fmp = new FormMdiParent();
            fmp.Show();
            toolStripStatusLabel1.Text = "File/FormMDI";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "File/Load";
            load();
        }
        private void load()
        {
            if (toolStripProgressBar1.Value == 100)
            {
                toolStripProgressBar1.Value = 0;

            }
            toolStripProgressBar1.Value = 100;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "File/Save";
            load();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExit fe = new FormExit();
            if (fe.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "File/UscitaAnnullata";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Savoldelli Alberto ©\nProject finished on 20/10/2020", "?");
            toolStripStatusLabel1.Text = "?";
        }
    }
}
