namespace Vikingos;

public class Jarl : Casta
{
    public override bool PuedeIrExpedicion(Vikingo vikingo)
    {
        if (vikingo is Soldado soldado && soldado.Armas > 0)
            return false;

        return vikingo.EsProductivo();
    }

    public override void Ascender(Vikingo vikingo)
    {
        vikingo.Casta = new Karl();

        if (vikingo is Soldado s)
            s.Armas += 10;

        if (vikingo is Granjero g)
        {
            g.Hijos += 2;
            g.Hectareas += 2;
        }
    }
}