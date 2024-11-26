namespace Biblioteca
{
    public abstract class ParamFactory
    {
        protected ParamFactory(string titlu)
        {
            Titlu = titlu;
        }

        public string Titlu
        { get; set; }
    }
}
