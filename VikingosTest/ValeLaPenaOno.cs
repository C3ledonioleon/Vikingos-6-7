      using Vikingos;
using Xunit;

namespace VikingostTest;

public class ValeLaPenaOno
{

    [Fact]
    public void ValeLaPena_TodosCumplen()
    {
        var exp = new Expedicion();
        exp.AgregarLugar(new Aldea(20));
        exp.AgregarLugar(new Capital(30, 3.0)); // 2 vikingos → 30×3=90 ≥ 6

        exp.SubirVikingo(new Soldado(new Karl(), 25, 3));
        exp.SubirVikingo(new Granjero(new Karl(), 2, 5));

        Assert.True(exp.ValeLaPena());
    }

    [Fact]
    public void ValeLaPena_FallaSiAmuralladaPocosVikingos()
    {
        var exp = new Expedicion();
        exp.AgregarLugar(new Amurallada(20, 5));

        for (int i = 0; i < 3; i++)
            exp.SubirVikingo(new Soldado(new Karl(), 25, 3));

        Assert.False(exp.ValeLaPena());
    }
}