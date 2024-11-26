namespace Biblioteca
{
    public class CarteParamFactory : ParamFactory
    {
        public CarteParamFactory(string autor, string titlu): base(titlu)
        {
            Autor = autor;
        }

        public string Autor
        { get; set; }
    }
}
