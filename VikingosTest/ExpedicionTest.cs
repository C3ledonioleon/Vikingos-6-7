using Xunit;
using Vikingos;

public class ExpedicionTests
{
    [Fact]
    public void NoSubeVikingoNoProductivo()
    {
        var vikingo = new Soldado(new Jarl(), 10, 5); // < 20 vidas
        var exp = new Expedicion();

        Assert.Throws<Exception>(() => exp.SubirVikingo(vikingo));
    }

    [Fact]
    public void NoSubeJarlConArmas()
    {
        var vikingo = new Soldado(new Jarl(), 30, 1);
        var exp = new Expedicion();

        Assert.Throws<Exception>(() => exp.SubirVikingo(vikingo));
    }
    
}