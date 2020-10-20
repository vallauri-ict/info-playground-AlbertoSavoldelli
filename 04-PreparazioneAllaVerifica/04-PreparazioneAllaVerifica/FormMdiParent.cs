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
    public partial class FormMdiParent : Form
    {
        public FormMdiParent()
        {
            InitializeComponent();
        }

        private void btnFormMdiChildren_Click(object sender, EventArgs e)
        {
            Point startPoint = new Point(0, 100);
            foreach (var item in this.MdiChildren)
            {
                startPoint.X += item.Width + 10;
            }
            FormMdiParent fm = new FormMdiParent();
            this.AddOwnedForm(fm);
            fm.Width = 100;
            fm.Height = 100;
            fm.StartPosition = FormStartPosition.Manual;
            fm.Location = startPoint;
            fm.Show();
        }
    }
}
