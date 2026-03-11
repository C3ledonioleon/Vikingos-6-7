using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vikingos
{
public class Soldado : Vikingo
{
    public int VidasCobradas { get; set; }
    public int Armas { get; set; }

    public Soldado(Casta casta, int vidasCobradas, int armas) : base(casta)
        {
            VidasCobradas = vidasCobradas;
            Armas = armas;
        }

    public override bool EsProductivo()
    {
        return VidasCobradas > 20 && Armas > 0;
    }
}
}