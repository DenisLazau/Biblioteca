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

        public void AdaugaMembru(Membru carte)
        {
            Adauga(carte);
        }
    }
}
