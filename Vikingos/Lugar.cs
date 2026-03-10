using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vikingos
{
    public abstract class Lugar
    {
        public abstract bool ValeLaPena(int cantidadVikingos);

        public abstract int ObtenerBotin(int cantidadVikingos);
    }
}