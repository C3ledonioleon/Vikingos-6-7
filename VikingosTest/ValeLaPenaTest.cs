using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Vikingos;

namespace VikingostTest;
public class ValeLaPena
{
    [Fact]
    public void ExpedicionValeLaPena()
    {
        // Arrange
        Expedicion expedicion = new Expedicion();

        Vikingo v1 = new Soldado(new Karl(), 30, 2);
        Vikingo v2 = new Granjero(new Karl(), 2, 10);

        expedicion.SubirVikingo(v1);
        expedicion.SubirVikingo(v2);

        expedicion.Lugares.Add(new Aldea(20));

        // Act
        bool resultado = expedicion.ValeLaPena();

        // Assert
        Assert.True(resultado);
    }
}