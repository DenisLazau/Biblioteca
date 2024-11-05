using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        public Biblioteca()
        {
            Catalog.Instance();
            ListaMembri.Instance();
        }

        public bool AdaugaCarte(string titlu, string autor)
        {
            Guid id = Guid.NewGuid();
            
            Carte carte = new Carte(id, titlu, autor, null, false, null);
            Catalog.AdaugaCarte(carte);
            return true;
        }

        public bool AdaugaMembru(string nume, string telefon, string adresa)
        {
            Guid id = Guid.NewGuid();

            Membru membru = new Membru(id, nume,telefon, adresa);
            ListaMembri.AdaugaMembru(membru);
            return true;
        }
    }
}
