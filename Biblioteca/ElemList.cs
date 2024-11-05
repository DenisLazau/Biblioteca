using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ElemList<T, K> where T : ICompare<K>
    {
        public List<T> lista;

        public ElemList(List<T> lista)
        {
            this.lista = lista;
        }

        public void Adauga(T item)
        {
            lista.Add(item);
        }
    }
}
