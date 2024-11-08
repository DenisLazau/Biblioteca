﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ListaMembri
    {
        private static ListaMembri singleton;
        private static List<Membru> listaMembri;

        private ListaMembri()
        {
            listaMembri = new List<Membru>();
        }

        public static ListaMembri Instance()
        {
            if (singleton == null)
            {
                singleton = new ListaMembri();
            }
            return singleton;
        }

        public static void AdaugaMembru(Membru carte)
        {
            listaMembri.Add(carte);
        }
    }
}
