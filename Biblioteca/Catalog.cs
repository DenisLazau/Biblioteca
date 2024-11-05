using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Catalog: ElemList<Carte, Guid>
    {
        private static Catalog singleton;

        private Catalog()
        {
            lista = new List<Carte>(0);
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
            ElemList<>.Adauga(carte);
        }


    }
}
