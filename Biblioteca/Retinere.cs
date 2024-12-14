namespace Biblioteca
{
    public class Retinere: ICompare<Guid>
    {
        public Retinere(Guid id, Guid idMembru, Guid idCarte, DateTime dataRetinerii)
        {
            Id = id;
            IdMembru = idMembru;
            IdCarte = idCarte;
            DataRetinerii = dataRetinerii;
        }

        public Guid Id
        { get; set; }

        public Guid IdMembru
        { get; set; }

        public Guid IdCarte
        { get; set; }

        public DateTime DataRetinerii
        { get; set; }

        public bool Compara(Guid id)
        {
            if (IdCarte == id)
            {
                return true;
            }
            return false;
        }
    }
}
