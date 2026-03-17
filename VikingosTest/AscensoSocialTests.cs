using Xunit;
using Vikingos;

public class AscensoSocialTests
{
    [Fact]
    public void Ragnar_DeKarlAScaleAThrall()
    {
        var ragnar = new Soldado(new Karl(), 45, 12);
        ragnar.Ascender();
        Assert.IsType<Thrall>(ragnar.Casta);
    }

    [Fact]
    public void JarlSoldado_AscenderGana10Armas()
    {
        var vikingo = new Soldado(new Jarl(), 30, 3);
        vikingo.Ascender();
        Assert.IsType<Karl>(vikingo.Casta);
        Assert.Equal(13, vikingo.Armas);
    }

    [Fact]
    public void JarlGranjero_AscenderGana2HijosYHectareas()
    {
        var vikingo = new Granjero(new Jarl(), 1, 4);
        vikingo.Ascender();
        Assert.IsType<Karl>(vikingo.Casta);
        Assert.Equal(3, vikingo.Hijos);
        Assert.Equal(6, vikingo.Hectareas);
    }

    [Fact]
    public void Thrall_NoAsciende()
    {
        var vikingo = new Soldado(new Thrall(), 50, 10);
        vikingo.Ascender();
        Assert.IsType<Thrall>(vikingo.Casta);
        Assert.Equal(10, vikingo.Armas);
    }
}