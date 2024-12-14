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

        public void Actualizeaza(T item, K id)
        {
            T? elementulGasit = lista.FirstOrDefault(x => x.Compara(id));
            if (elementulGasit != null)
            {
                lista.Remove(elementulGasit);
                lista.Add(item);
            }
        }

        public void Elimina(T item)
        {
            lista.Remove(item);
        }

        public T? Cauta(K id)
        {
            T? elementulGasit = lista.FirstOrDefault(x => x.Compara(id));
            return elementulGasit;
        }
    }
}
