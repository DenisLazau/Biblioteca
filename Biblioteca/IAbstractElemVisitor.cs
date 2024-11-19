namespace Biblioteca
{
    public interface IAbstractElemVisitor
    {
        void Visit(AbstractElem elem);
        void Visit(Carte carte);
        void Visit(Revista revista);
    }
}
