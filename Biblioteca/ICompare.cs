﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface ICompare<K>
    {
        public bool Compara(K id);
    }
}
