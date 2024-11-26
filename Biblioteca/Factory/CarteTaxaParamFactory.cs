namespace Biblioteca
{
    public class CarteTaxaParamFactory : CarteParamFactory
    {
        public CarteTaxaParamFactory(int taxa, string autor, string titlu) : base(autor, titlu)
        {
            Taxa = taxa;
        }

        public int Taxa
        { get; set; }
    }
}
