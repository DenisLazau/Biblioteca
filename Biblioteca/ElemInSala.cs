namespace Biblioteca
{
    public class ElemInSala : AbstractElem
    {
        public ElemInSala(AbstractElem elem, bool sala) : base(new Guid(), null)
        {
            Element = elem;
            Sala = sala;
        }

        public AbstractElem Element
        { get; set; }

        public bool Sala
        { get; set; }
    }
}
