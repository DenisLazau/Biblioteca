namespace Biblioteca
{
    public class RevistaSalaParamFactory : RevistaParamFactory
    {
        public RevistaSalaParamFactory(bool sala, int numar, string titlu) : base(numar, titlu)
        {
            Sala = sala;
        }

        public bool Sala
        { get; set; }
    }
}
