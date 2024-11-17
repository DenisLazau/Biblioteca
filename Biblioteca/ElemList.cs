namespace Biblioteca
{
    public class ElemList<T, K> where T : ICompare<K>
    {
        public List<T> lista;

        public ElemList()
        {
            lista = new List<T>();
        }

        public void Adauga(T item)
        {
            lista.Add(item);
        }
    }
}
