using Xunit;
using Vikingos;

namespace VikingosTests;

public class UnitTest1
{
    [Fact]
    public void NoDebeSubirVikingoSiNoPuedeIr()
    {
        // Arrange
        var expedicion = new Expedicion();

        var soldado = new Soldado
        {
            VidasCobradas = 10,
            Armas = 1,
            Casta = new Karl()
        };

        // Act & Assert
        Assert.Throws<Exception>(() => expedicion.SubirVikingo(soldado));
    }
}

