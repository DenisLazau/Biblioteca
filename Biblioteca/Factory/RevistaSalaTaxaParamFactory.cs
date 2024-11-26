namespace Biblioteca
{
    public class RevistaSalaTaxaParamFactory : RevistaParamFactory
    {
        public RevistaSalaTaxaParamFactory(int taxa, bool sala, int numar, string titlu) : base(numar, titlu)
        {
            Sala = sala;
            Taxa = taxa;
            Numar = numar;
        }

        public bool Sala
        { get; set; }

        public int Taxa
        { get; set; }
    }
}
