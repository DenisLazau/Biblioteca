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

        public void AdaugaAbstractElem(AbstractElem carte)
        {
            Adauga(carte);
        }

        public AbstractElem? CautaAbstractElem(Guid id)
        {
            AbstractElem? membrulGasit = Cauta(id);
            return membrulGasit;
        }

        public void EliminaAbstractElem(AbstractElem carte)
        {
            Elimina(carte);
        }
    }
}
