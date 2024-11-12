using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Catalog: ElemList<AbstractElem, Guid>
    {
        private static Catalog singleton;

        private Catalog()
        {
        }

        public static Catalog Instance()
        {
            if (singleton == null)
            {
                singleton = new Catalog();
            }
            return singleton;
        }

        public void AdaugaCarte(AbstractElem carte)
        {
            Adauga(carte);
        }


    }
}
