      using Vikingos;
using Xunit;

namespace VikingostTest;

public class test
{

    [Fact]
    public void ExpedicionNoValeLaPena()
    {
        // Arrange
        Expedicion expedicion = new Expedicion();

        Vikingo v1 = new Soldado(new Karl(), 30, 2);
        Vikingo v2 = new Granjero(new Karl(), 2, 10);

        expedicion.SubirVikingo(v1);
        expedicion.SubirVikingo(v2);

        expedicion.Lugares.Add(new Aldea(10));

        // Act
        bool resultado = expedicion.ValeLaPena();

        // Assert
        Assert.False(resultado);
    }
}