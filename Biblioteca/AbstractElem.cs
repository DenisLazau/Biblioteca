namespace Biblioteca
{
    public class AbstractElem : ICompare<Guid>
    {
        public AbstractElem(Guid id, string? titlu)
        {
            Id = id;
            Titlu = titlu;
        }

        public Guid Id
        { get; set; }

        public string? Titlu
        { get; set; }

        public Guid? IdMembru
        { get; set; }

        public bool Imprumutata
        { get; set; }

        public DateTime? ImprumutataPanaLa
        { get; set; }

        public bool Compara(Guid id)
        {
            if (Id == id)
            {
                return true;
            }
            return false;
        }

        public virtual void Accept(IAbstractElemVisitor viz)
        {
        }
    }
}
