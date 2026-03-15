using Xunit;
using Vikingos;

public class LugaresTests
{
    [Fact]
    public void AldeaValeLaPena()
    {
        Assert.False(new Aldea(14).ValeLaPena(10));
        Assert.True(new Aldea(15).ValeLaPena(10));
    }

    [Fact]
    public void CapitalValeLaPena()
    {
        var cap = new Capital(20, 2.0);
        Assert.True(cap.ValeLaPena(10));   // 20×2 = 40 ≥ 30
        Assert.False(cap.ValeLaPena(30));  // 20×2 = 40 < 90
    }
}