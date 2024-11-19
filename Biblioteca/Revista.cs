namespace Biblioteca
{
    public class Revista : AbstractElem
    {
        public Revista(Guid id, string titlu, int numar)
            : base(id, titlu)
        {
            Numar = numar;
        }

        public int Numar
        { get; set; }

        public bool Compara(Guid id)
        {
            throw new NotImplementedException();
        }

        public override void Accept(IAbstractElemVisitor viz)
        {
            //obiectul vizitator primit ca parametru "viziteaza" obiectul curent
            viz.Visit(this);
        }
    }
}
