namespace Biblioteca
{
    public class CarteSalaTaxaParamFactory : CarteParamFactory
    {
        public CarteSalaTaxaParamFactory(int taxa, bool sala, string autor, string titlu) : base(autor, titlu)
        {
            Sala = sala;
            Taxa = taxa;
        }

        public bool Sala
        { get; set; }

        public int Taxa
        { get; set; }
    }
}
