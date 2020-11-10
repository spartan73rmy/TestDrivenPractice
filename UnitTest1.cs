using NUnit.Framework;

namespace TestDrivenPractice
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetIva()
        {
            //Arrange
            CalculadorImpuestos calculador = new CalculadorImpuestos();
            decimal monto = 1550.0M;

            //Act 
            decimal iva = calculador.GetIva(monto);

            //Assert 
            //IVA 16% * 1550 = 248  
            Assert.AreNotEqual(248.01M, iva);
            Assert.AreEqual(248.00M, iva);
        }

        [Test]
        public void GetISH()
        {
            //Arrange
            CalculadorImpuestos calculador = new CalculadorImpuestos();
            decimal monto = 1550.0M;
            decimal porcentaje = .13M;

            //Act
            decimal ish = calculador.GetISH(monto, porcentaje);

            //Assert
            Assert.AreEqual(201.5, ish);
        }

        [Test]
        public void GetMontoTotal()
        {
            CalculadorImpuestos calculador = new CalculadorImpuestos();
            decimal monto = 1550.0M;
            decimal porcentaje = 0.3M;

            decimal montoTotal = calculador.GetMontoTotal(monto, porcentaje);

            //(.16*1550) + (1550*.3)
            Assert.AreEqual(713, montoTotal);
        }
    }
}