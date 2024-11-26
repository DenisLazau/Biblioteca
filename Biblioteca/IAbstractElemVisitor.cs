namespace Biblioteca
{
    public interface IAbstractElemVisitor
    {
        string Visit(AbstractElem carte);
        string Visit(Carte carte);
        string Visit(Revista revista);
        string Visit(ElemCuTaxa elemCuTaxa);
        string Visit(ElemInSala elemInSala);
    }
}
