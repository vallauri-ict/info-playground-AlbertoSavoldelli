using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_Dispense_Mana_1
{
    public delegate void salvataggioEseguitoEventHandler(int id);
    class GestoreSalvataggio
    {
        public event salvataggioEseguitoEventHandler salvataggioEseguito;

        public void salvaSuFile(int id)
        {

            MessageBox.Show("Sto eseguendo il salvataggio");

            salvataggioEseguito(id);
        }
    }
}
