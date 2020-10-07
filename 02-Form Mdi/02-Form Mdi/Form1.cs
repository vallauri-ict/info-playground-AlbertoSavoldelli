using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Form_Mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAprif1_Click(object sender, EventArgs e)
        {
            FormFiglia1 f = new FormFiglia1();
            f.Text = "Figlia 1";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 0);
            f.Show();
        }

        private void btnAprif2_Click(object sender, EventArgs e)
        {
            FormFiglia2 f = new FormFiglia2();
            f.Text = "Figlia 2";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 0);
            f.Show();

        }

        private void btnFinestreAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte "+MdiChildren.Length+" finestre");
            foreach  (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra "+f.Text+" aperta");
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModalEsci f = new FormModalEsci();
            f.Text = "Uscire";
            if (f.ShowDialog() == DialogResult.Cancel)
                f.Close();
            else 
                if(f.ShowDialog() == DialogResult.OK)
                Close();


        }
    }
}
