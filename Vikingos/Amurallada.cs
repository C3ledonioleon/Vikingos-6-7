using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vikingos;

public class Amurallada : Aldea
{
    public int MinimoVikingos { get; set; }

    public Amurallada(int crucifijos, int minimoVikingos) : base(crucifijos)
    {
        MinimoVikingos = minimoVikingos;
    }

    public override bool ValeLaPena(int cantidadVikingos)
    {
        return base.ValeLaPena(cantidadVikingos) && cantidadVikingos >= MinimoVikingos;
    }
}
