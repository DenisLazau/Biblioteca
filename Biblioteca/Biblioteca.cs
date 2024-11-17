namespace Biblioteca
{
    public class Biblioteca
    {
        Catalog catalog;
        AbstractElemFactory abstractElemFactory;
        public Biblioteca()
        {
            catalog = Catalog.Instance();
            abstractElemFactory = AbstractElemFactory.Instance();
            ListaMembri.Instance();
        }

        public bool AdaugaCarte(ParamFactory param)
        {
            Guid id = Guid.NewGuid();

            AbstractElem elem = abstractElemFactory.CreeazaElementConcret(param);
            catalog.AdaugaCarte(elem);
            return true;
        }

        public bool AdaugaMembru(string nume, string telefon, string adresa)
        {
            Guid id = Guid.NewGuid();

            Membru membru = new Membru(id, nume, telefon, adresa);
            ListaMembri.AdaugaMembru(membru);
            return true;
        }
    }
}
