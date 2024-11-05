using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carte : ICompare<Guid>
    {
        public Carte(Guid id, string titlu, string autor, int? idMembru, bool imprumutata, DateTime? imprumutataPanaLa)
        {
            Id = id;
            Titlu = titlu;
            Autor = autor;
            IdMembru = idMembru;
            Imprumutata = imprumutata;
            ImprumutataPanaLa = imprumutataPanaLa;
        }

        public Guid Id
        { get; set; }

        public string Titlu
        { get; set; }

        public string Autor
        { get; set; }

        public int? IdMembru
        { get; set; }

        public bool Imprumutata
        { get; set; }

        public DateTime? ImprumutataPanaLa
        { get; set; }

        public bool Compara(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
