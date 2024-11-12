using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CarteParamFactory : ParamFactory
    {
        public CarteParamFactory(string autor)
        {
            Autor = autor;
        }

        public string Autor
        { get; set; }
    }
}
