namespace Biblioteca
{
    public class RevistaParamFactory : ParamFactory
    {
        public RevistaParamFactory(int numar, string titlu): base(titlu)
        {
            Numar = numar;
        }

        public int Numar
        { get; set; }
    }
}
