namespace Vikingos;

public class Karl : Casta
{
    public override bool PuedeIrExpedicion(Vikingo vikingo)
    {
        return vikingo.EsProductivo();
    }

    public override void Ascender(Vikingo vikingo)
    {
        vikingo.Casta = new Thrall();
    }
}