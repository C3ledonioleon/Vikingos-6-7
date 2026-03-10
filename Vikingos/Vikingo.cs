using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Vikingos
{
    public abstract class Vikingo
    {
        public Casta Casta { get; set; }

        public Vikingo(Casta casta)
        {
            Casta = casta;
        }
         public abstract bool EsProductivo();
    }


}