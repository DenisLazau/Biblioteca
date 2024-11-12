using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AbstractElemFactory
    {
        private static AbstractElemFactory singleton;

        private AbstractElemFactory()
        {
        }

        public static AbstractElemFactory Instance()
        {
            if (singleton == null)
            {
                singleton = new AbstractElemFactory();
            }
            return singleton;
        }

        public AbstractElem CreeazaElementConcret(ParamFactory paramFactory)
        {
            AbstractElem? elem = null;

            switch (paramFactory)
            {
                case CarteParamFactory carte:
                    elem = new Carte(carte.Id, carte.Titlu, carte.Autor);
                    break;
                default:
                    // code block
                    break;
            }


            return elem!;

        }
    }
}
