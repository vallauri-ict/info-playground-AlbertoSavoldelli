﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Persone_Studenti
{
    class studente : persona
    {
        public List<int> voti = new List<int>();

        public void aggiungiVoto(int voto)
        {
            voti.Add(voto);
        }
        public double Media()
        {
            int sommaVoti = 0;
            foreach (var item in voti)
            {
                sommaVoti += item;
            }
            return (double)sommaVoti / voti.Count();
        }

        
    }
}
