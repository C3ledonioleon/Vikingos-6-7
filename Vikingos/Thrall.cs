namespace Vikingos;

public class Thrall : Casta
{
    public override bool PuedeIrExpedicion(Vikingo vikingo)
    {
        return vikingo.EsProductivo();
    }

    public override void Ascender(Vikingo vikingo)
    {
        throw new InvalidOperationException("No");
    }
}