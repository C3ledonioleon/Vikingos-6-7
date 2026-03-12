using Vikingos;
using Xunit;

public class ExpedicionTest
{
    [Fact]
        public void NoDebeSubirVikingoNoProductivo()
        {
            Expedicion expedicion = new Expedicion();
            Vikingo vikingo = new Soldado(new Karl(), 10, 0);

            var ex = Assert.Throws<Exception>(() => expedicion.SubirVikingo(vikingo));

            Assert.Equal("El vikingo no puede subir a la expedición", ex.Message);
        }
}