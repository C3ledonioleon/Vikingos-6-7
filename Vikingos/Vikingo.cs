using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;


namespace Vikingos
{
    public abstract class Vikingo
    {
        public Casta Casta { get; set; }
        public int Oro { get; set; }

        public Vikingo(Casta casta)
        {
            Casta = casta;
        }

        public abstract bool EsProductivo();

        public void Ascender()
        {
            Casta.Ascender(this);
        }
    }
}