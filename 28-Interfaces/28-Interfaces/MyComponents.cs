using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Interfaces
{
    class MyComponents : IDispAgggiuntivo
    {
        private int _id;
        private bool _status;
        public int id { get => _id; set => _id=value; }

        public bool status => _status;

        public void connetti(string s)
        {
            _status = true;
            id++;
            System.Windows.Forms.MessageBox.Show("Connesso a: "+s);
        }

        public void disconnetti(string s)
        {
            _status = false;
            System.Windows.Forms.MessageBox.Show("Disconnesso a: " + s);
        }

        public void Stato()
        {
            if(status)
                System.Windows.Forms.MessageBox.Show("Attualmente connesso con id"+ id);
            else
                System.Windows.Forms.MessageBox.Show("Non connesso");
        }
    }
}
