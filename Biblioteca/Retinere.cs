namespace Biblioteca
{
    public class Retinere
    {
        public Retinere(int id, int idMembru, int idCarte, DateTime dataRetinerii)
        {
            Id = id;
            IdMembru = idMembru;
            IdCarte = idCarte;
            DataRetinerii = dataRetinerii;
        }

        public int Id
        { get; set; }

        public int IdMembru
        { get; set; }

        public int IdCarte
        { get; set; }

        public DateTime DataRetinerii
        { get; set; }
    }
}
