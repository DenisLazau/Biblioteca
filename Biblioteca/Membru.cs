namespace Biblioteca
{
    public class Membru
    {
        public Guid Id
        { get; set; }

        public string Nume
        { get; set; }

        public string Telefon
        { get; set; }

        public string Adresa
        { get; set; }

        public Membru(Guid id, string nume, string telefon, string adresa)
        {
            Id = id;
            Nume = nume;
            Telefon = telefon;
            Adresa = adresa;
        }
    }
}
