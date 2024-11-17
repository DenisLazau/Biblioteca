namespace Biblioteca
{
    public class CarteParamFactory : ParamFactory
    {
        public CarteParamFactory(string autor)
        {
            Autor = autor;
        }

        public string Autor
        { get; set; }
    }
}
