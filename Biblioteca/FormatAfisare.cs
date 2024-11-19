using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class FormatAfisare : IAbstractElemVisitor
    {
        public void Visit(AbstractElem elem) { }
        public void Visit(Carte carte) { }
        public void Visit(Revista revista) { }
    }
}
