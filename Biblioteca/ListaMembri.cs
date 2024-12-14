namespace Biblioteca
{
    public class ListaMembri: ElemList<Membru, Guid>
    {
        private static ListaMembri singleton;

        private ListaMembri()
        {
        }

        public static ListaMembri Instance()
        {
            if (singleton == null)
            {
                singleton = new ListaMembri();
            }
            return singleton;
        }

        public void AdaugaMembru(Membru membru)
        {
            Adauga(membru);
        }

        public Membru? CautaMembru(Guid id)
        {
            Membru? membrulGasit = Cauta(id);
            return membrulGasit;
        }

        public void EliminaMembru(Membru membru)
        {
            Elimina(membru);
        }
    }
}
