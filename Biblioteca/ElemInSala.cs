using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ElemInSala : AbstractElem
    {
        public ElemInSala(AbstractElem elem, bool sala) : base(new Guid(), null)
        {
            Element = elem;
            Sala = sala;
        }

        public AbstractElem Element
        { get; set; }

        public bool Sala
        { get; set; }
    }
}
