using System;
using System.Collections.Generic;
using System.Linq;

namespace Vikingos;

public class Expedicion
{
    public List<Vikingo> Vikingos { get; private set; }
    public List<Lugar> Lugares { get; private set; }

    public Expedicion()
    {
        Vikingos = new List<Vikingo>();
        Lugares = new List<Lugar>();
    }

    public void SubirVikingo(Vikingo vikingo)
    {
        if (vikingo.Casta.PuedeIrExpedicion(vikingo))
        {
            Vikingos.Add(vikingo);
        }
        else
        {
            throw new Exception("El vikingo no puede subir a la expedición");
        }
    }

    public bool ValeLaPena()
    {
        int cantidad = Vikingos.Count;

        return Lugares.All(l => l.ValeLaPena(cantidad));
    }

    public int RealizarExpedicion()
    {
        int totalBotin = 0;
        int cantidad = Vikingos.Count;

        foreach (var lugar in Lugares)
        {
            totalBotin += lugar.ObtenerBotin(cantidad);
        }

        return totalBotin;
    }
}