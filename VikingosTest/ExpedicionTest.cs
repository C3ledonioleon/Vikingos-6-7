using Vikingos;
using Xunit;

namespace VikingosTest;

public class ExpedicionTest
{
    [Fact]
    public void RealizarExpedicionDivideBotin()
    {
        // Arrange
        Expedicion expedicion = new Expedicion();

        Vikingo v1 = new Soldado(new Karl(), 30, 2);
        Vikingo v2 = new Granjero(new Karl(), 2, 10);

        expedicion.SubirVikingo(v1);
        expedicion.SubirVikingo(v2);

        expedicion.Lugares.Add(new Aldea(20));

        // Act
        int botin = expedicion.RealizarExpedicion();

        // Assert
        Assert.Equal(10, botin);
    }
}