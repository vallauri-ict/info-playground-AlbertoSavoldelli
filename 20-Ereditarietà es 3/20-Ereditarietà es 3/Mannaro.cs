﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Ereditarietà_es_3
{
    class Mannaro: Mostro
    {
        new public string nome;
        public Mannaro()
        : base()

        {
            this.nome = "Mannaro";
        }
        public Mannaro(string nome): base(nome)

        {
            this.nome = "Mannaro" + nome;
        }
        new public void Rivela()
        {
            string s = nome + (char)(32);
            System.Windows.Forms.MessageBox.Show(s + base.nome);
        }
    }
}
