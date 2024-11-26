namespace Biblioteca
{
    public class CarteSalaParamFactory : CarteParamFactory
    {
        public CarteSalaParamFactory(bool sala, string autor, string titlu) : base(autor, titlu)
        {
            Sala = sala;
        }

        public bool Sala
        { get; set; }
    }
}
