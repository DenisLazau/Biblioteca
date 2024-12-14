namespace Biblioteca
{
    public class Biblioteca
    {
        Catalog catalog;
        AbstractElemFactory abstractElemFactory;
        ListaMembri listaMembri;
        Retineri retineri;
        public Biblioteca()
        {
            catalog = Catalog.Instance();
            abstractElemFactory = AbstractElemFactory.Instance();
            listaMembri = ListaMembri.Instance();
            retineri = Retineri.Instance();
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

        public Membru? CautaMembru(Guid id)
        {
            Membru? membru = listaMembri.CautaMembru(id);
            return membru;
        }

        public AbstractElem? CautaCarte(Guid id)
        {
            AbstractElem? membru = catalog.CautaAbstractElem(id);
            return membru;
        }

        public bool? EliminaMembru(Guid id)
        {
            Membru? membru = listaMembri.CautaMembru(id);
            if (membru == null)
            {
                return false;
            }
            listaMembri.Elimina(membru);
            return true;
        }

        public bool? EliminaRetinere(Guid id)
        {
            Retinere? retinere = retineri.Cauta(id);
            if (retinere == null)
            {
                return false;
            }
            retineri.Elimina(retinere);
            return true;
        }

        public bool? EliminaAbstractElem(Guid id)
        {
            AbstractElem? abstractElem = catalog.CautaAbstractElem(id);
            if (abstractElem == null)
            {
                return false;
            }
            catalog.EliminaAbstractElem(abstractElem);
            return true;
        }

        public bool? AdaugaRetinere(Guid idMembru, Guid idCarte)
        {
            try
            {
                AbstractElem? elem = catalog.CautaAbstractElem(idCarte);
                if (elem == null)
                {
                    return false;
                }
                Membru? membru = listaMembri.CautaMembru(idMembru);
                if (membru == null)
                {
                    return false;
                }
                if(elem.Imprumutata)
                {
                    return false;
                }
                Guid id = Guid.NewGuid();
                Retinere retinere = new Retinere(id, idCarte, idMembru, DateTime.Now);
                retineri.Adauga(retinere);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool? ImprumutaCarte(Guid idMembru, Guid idCarte)
        {
            try
            {
                AbstractElem? elem = catalog.CautaAbstractElem(idCarte);
                if (elem == null)
                {
                    return false;
                }
                Membru? membru = listaMembri.CautaMembru(idMembru);
                if (membru == null)
                {
                    return false;
                }
                catalog.Actualizeaza(elem, elem.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool? ReturneazaCarte(Guid idMembru, Guid idCarte)
        {
            try
            {
                AbstractElem? elem = catalog.CautaAbstractElem(idCarte);
                if (elem == null)
                {
                    return false;
                }
                Membru? membru = listaMembri.CautaMembru(idMembru);
                if (membru == null)
                {
                    return false;
                }
                elem.Imprumutata = false;
                elem.ImprumutataPanaLa = null;
                elem.IdMembru = null;
                catalog.Actualizeaza(elem, elem.Id);
                Retinere? retinere = retineri.Cauta(idCarte);
                if (retinere == null)
                {
                    return true;
                }

                ProcesareRetinere(retinere, membru, elem);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool? ProcesareRetinere(Retinere retinere, Membru membru, AbstractElem elem)
        {
            try
            {
                retineri.Elimina(retinere);
                elem.Imprumutata = true;
                elem.ImprumutataPanaLa = DateTime.Now.AddDays(14);
                elem.IdMembru = membru.Id;
                catalog.Actualizeaza(elem, elem.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
