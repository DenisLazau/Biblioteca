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
                case CarteSalaParamFactory carte:
                    elem = new ElemInSala(new Carte(id, carte.Titlu, carte.Autor), carte.Sala);
                    break;
                case RevistaSalaParamFactory revista:
                    elem = new ElemInSala(new Revista(id, revista.Titlu, revista.Numar), revista.Sala);
                    break;
                case CarteTaxaParamFactory carte:
                    elem = new ElemCuTaxa(new Carte(id, carte.Titlu, carte.Autor), carte.Taxa);
                    break;
                case RevistaTaxaParamFactory revista:
                    elem = new ElemCuTaxa(new Revista(id, revista.Titlu, revista.Numar), revista.Taxa);
                    break;
                case CarteSalaTaxaParamFactory carte:
                    elem = new ElemInSala(new ElemCuTaxa(new Carte(id, carte.Titlu, carte.Autor), carte.Taxa), carte.Sala);
                    break;
                case RevistaSalaTaxaParamFactory revista:
                    elem = new ElemInSala(new ElemCuTaxa(new Revista(id, revista.Titlu, revista.Numar), revista.Taxa), revista.Sala);
                    break;
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
