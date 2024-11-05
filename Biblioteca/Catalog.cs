using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Catalog
    {
        private static List<Carte> listaCarti;
        private static Catalog singleton;

        private Catalog()
        {
            listaCarti = new List<Carte>();
        }

        public static Catalog Instance()
        {
            if (singleton == null)
            {
                singleton = new Catalog();
            }
            return singleton;
        }

        public static void AdaugaCarte(Carte carte)
        {
            listaCarti.Add(carte);
        }
    }
}
