namespace Biblioteca
{
    public class RevistaTaxaParamFactory : RevistaParamFactory
    {
        public RevistaTaxaParamFactory(int taxa, int numar, string titlu) : base(numar, titlu)
        {
            Taxa = taxa;
        }

        public int Taxa
        { get; set; }
    }
}
