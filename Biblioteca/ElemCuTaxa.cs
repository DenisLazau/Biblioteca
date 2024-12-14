namespace Biblioteca
{
    public class ElemCuTaxa : AbstractElem
    {
        public ElemCuTaxa(AbstractElem elem, int taxa) : base(new Guid(), null)
        {
            Element = elem;
            Taxa = taxa;
        }

        public AbstractElem Element
        { get; set; }

        public int Taxa
        { get; set; }
    }
}
