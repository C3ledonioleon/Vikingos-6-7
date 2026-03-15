using Xunit;
using Vikingos;

public class AscensoSocialTests
{
    [Fact]
    public void AsciendeDeKarlAThrall()
    {
        var ragnar = new Soldado(new Karl(), 40, 8);
        ragnar.Ascender();
        Assert.IsType<Thrall>(ragnar.Casta);
    }

    [Fact]
    public void JarlSoldadoGanaArmasAlAscender()
    {
        var v = new Soldado(new Jarl(), 30, 2);
        v.Ascender();
        Assert.IsType<Karl>(v.Casta);
        Assert.Equal(12, v.Armas);
    }

    [Fact]
    public void Thrall_NoCambiaAlAscender()
    {
        var v = new Soldado(new Thrall(), 50, 10);
        v.Ascender();
        Assert.IsType<Thrall>(v.Casta);
        Assert.Equal(10, v.Armas);
    }
}