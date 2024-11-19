namespace Biblioteca
{
    public class AbstractElem : ICompare<Guid>
    {
        public AbstractElem(Guid id, string titlu)
        {
            Id = id;
            Titlu = titlu;
        }

        public Guid Id
        { get; set; }

        public string Titlu
        { get; set; }

        public int? IdMembru
        { get; set; }

        public bool Imprumutata
        { get; set; }

        public DateTime? ImprumutataPanaLa
        { get; set; }

        public bool Compara(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual void Accept(IAbstractElemVisitor viz)
        {
        }
    }
}
