namespace Biblioteca
{
    public class Carte : AbstractElem
    {
        public Carte(Guid id, string titlu, string autor)
            : base(id, titlu)
        {
            Autor = autor;
        }

        public string Autor
        { get; set; }

        public bool Compara(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
