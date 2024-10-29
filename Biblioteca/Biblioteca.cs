using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        public static Biblioteca biblioteca = new Biblioteca(new List<Membru>(), new List<Carte>());
        public Biblioteca(List<Membru> membrii, List<Carte> carte)
        {
            Membrii = membrii;
            Carti = carte;
        }

        public List<Membru> Membrii
        { get; set; }

        public List<Carte> Carti
        { get; set; }
    }
}
