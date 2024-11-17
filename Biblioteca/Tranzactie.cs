namespace Biblioteca
{
    public class Tranzactie
    {
        public int Id
        { get; set; }

        public int IdMembru
        { get; set; }

        public int IdCarte
        { get; set; }

        public string TransactionType
        { get; set; }

        public DateTime Date
        { get; set; }

        public Tranzactie(int id, int idMembru, int idCarte, string transactionType, DateTime date)
        {
            Id = id;
            IdMembru = idMembru;
            IdCarte = idCarte;
            TransactionType = transactionType;
            Date = date;
        }
    }
}
