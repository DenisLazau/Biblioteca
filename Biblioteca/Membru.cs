using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Membru: ICompare<K>
    {
        public Guid Id
        { get; set; }

        public string Nume
        { get; set; }

        public string Telefon
        { get; set; }

        public string Adresa
        { get; set; }

        public Membru(Guid id, string nume, string telefon, string adresa)
        {
            Id = id;
            Nume = nume;
            Telefon = telefon;
            Adresa = adresa;
        }

        public bool Compara(K id)
        {
            throw new NotImplementedException();
        }
    }
}
