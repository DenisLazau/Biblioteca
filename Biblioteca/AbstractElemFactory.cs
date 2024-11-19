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
            Guid id = Guid.NewGuid();

            switch (paramFactory)
            {
                case CarteParamFactory carte:
                    elem = new Carte(id, carte.Titlu, carte.Autor);
                    break;
                case RevistaParamFactory revista:
                    elem = new Revista(id, revista.Titlu, revista.Numar);
                    break;
                default:
                    break;
            }

            return elem!;

        }
    }
}
