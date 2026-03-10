using System.Collections.Generic;
using System.Linq;

namespace Vikingos;
public class Expedicion
{
    public List<Vikingo> Vikingos { get; set; }
    public List<Lugar> Lugares { get; set; }

    public Expedicion()
    {
        Vikingos = new List<Vikingo>();
        Lugares = new List<Lugar>();
    }

    public void SubirVikingo(Vikingo vikingo)
    {
        if (vikingo.EsProductivo())
        {
            Vikingos.Add(vikingo);
        }
    }

    public bool ValeLaPena()
    {
        int cantidad = Vikingos.Count;
        return Lugares.All(l => l.ValeLaPena(cantidad));
    }

    public int RealizarExpedicion()
    {
        int total = 0;
        int cantidad = Vikingos.Count;

        foreach (var lugar in Lugares)
        {
            total += lugar.ObtenerBotin(cantidad);
        }

        return total;
    }
}