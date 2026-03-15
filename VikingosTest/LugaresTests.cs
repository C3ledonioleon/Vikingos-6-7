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
    var cap = new Capital(25, 4.0);

    Assert.True(cap.ValeLaPena(5));   // 5×4 = 20 ≥ 15 → true
    Assert.False(cap.ValeLaPena(34)); // max 100 < 102 → false
}
}