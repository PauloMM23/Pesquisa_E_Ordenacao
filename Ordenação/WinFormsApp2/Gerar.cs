﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    class Gerar
    {
        public List<int> popularLista(int quantidade)
        {
            List<int> lista = new List<int> ();
            Random gerador = new Random();
            for (int i = 0; i < quantidade; i++)
            {
                lista.Add(gerador.Next(1000));
            }
            return lista;
        }
        
        
    }
}