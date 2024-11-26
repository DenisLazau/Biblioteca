namespace Biblioteca
{
    public class Biblioteca
    {
        Catalog catalog;
        AbstractElemFactory abstractElemFactory;
        ListaMembri listaMembri;
        public Biblioteca()
        {
            catalog = Catalog.Instance();
            abstractElemFactory = AbstractElemFactory.Instance();
            listaMembri = ListaMembri.Instance();
        }

        public bool AdaugaElement(ParamFactory param)
        {
            Guid id = Guid.NewGuid();

            AbstractElem elem = abstractElemFactory.CreeazaElementConcret(param);
            catalog.AdaugaAbstractElem(elem);
            return true;
        }

        public bool AdaugaMembru(string nume, string telefon, string adresa)
        {
            Guid id = Guid.NewGuid();

            Membru membru = new Membru(id, nume, telefon, adresa);
            listaMembri.AdaugaMembru(membru);
            return true;
        }
    }
}
