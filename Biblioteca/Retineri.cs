namespace Biblioteca
{
    public class Retineri: ElemList<Retinere, Guid>
    {
        private static Retineri singleton;

        private Retineri()
        {
        }

        public static Retineri Instance()
        {
            if (singleton == null)
            {
                singleton = new Retineri();
            }
            return singleton;
        }

        public void AdaugaRetinere(Retinere retinere)
        {
            Adauga(retinere);
        }

        public Retinere? CautaAbstractElem(Guid idCarte)
        {
            Retinere? retinereaGasita = Cauta(idCarte);
            return retinereaGasita;
        }

        public void EliminaAbstractElem(Retinere retinere)
        {
            Elimina(retinere);
        }
    }
}
