using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vikingos
{
public class Aldea : Lugar
{
    public int Crucifijos { get; set; }

    public Aldea(int crucifijos)
    {
        Crucifijos = crucifijos;
    }

    public override int ObtenerBotin(int cantidadVikingos)
    {
        return Crucifijos;
    }

    public override bool ValeLaPena(int cantidadVikingos)
    {
        return Crucifijos >= 15;
    }
}
}