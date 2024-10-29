using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        public Biblioteca(List<Membru> membrii, List<Carte> carte)
        {
            Membrii = membrii;
            Carte = carte;
        }

        public List<Membru> Membrii
        { get; set; }

        public List<Carte> Carte
        { get; set; }

    }
}
