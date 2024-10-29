using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ElemList<T, K> : ICompare<K>
    {
        bool ICompare<K>.Compara(K id)
        {
            return true;
        }
    }
}
