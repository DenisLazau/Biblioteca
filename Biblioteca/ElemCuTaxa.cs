using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ElemCuTaxa : AbstractElem
    {
        public ElemCuTaxa(AbstractElem elem, int taxa) : base(null, null)
        {
            Element = elem;
            Taxa = taxa;
        }

        public AbstractElem Element
        { get; set; }

        public int Taxa
        { get; set; }
    }
}
