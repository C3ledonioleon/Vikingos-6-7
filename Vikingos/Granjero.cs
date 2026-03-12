using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vikingos
{
    public class Granjero : Vikingo
    {
        public int Hijos { get; set; }
        public int Hectareas { get; set; }

        public Granjero(Casta casta, int hijos, int hectareas) : base(casta)
        {
            Hijos = hijos;
            Hectareas = hectareas;
        }

        public override bool EsProductivo()
        {
            return Hectareas >= Hijos * 2;
        }
    }
}