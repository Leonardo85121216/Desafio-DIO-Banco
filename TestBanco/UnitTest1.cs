using BancoNameSpace;

namespace TestBanco
{
    public class UnitTest1
    {
        [Fact]
        public void TesteSomaDeSaldo()
        {
            Caixa caixa = new Caixa();

            int resultado = caixa.AdcionarDinheiro(200);

            Assert.Equal(1200, resultado);
            
        }

        [Fact]
        public void TesteRetiradaDeSaldo()
        {
            Caixa caixa = new Caixa();

            int resultado = caixa.RetirarDinheiro(200);

            Assert.Equal(800, resultado);

        }

        [Fact]
        public void TestePedirEmprestimoEVerSaldo()
        {
            Caixa caixa = new Caixa();

            decimal resultado = caixa.PedirEmprestimo(500, 12);

            Assert.Equal(1500, resultado);
        }

        [Theory]
        [InlineData(1000, 12, 100.00)]
        [InlineData(500, 12, 50.00)]
        public void TestePedirEmprestimoEVerValorAPagarPorMes(decimal valor, int parcelamento, decimal res)
        {
            Caixa caixa = new Caixa();
            
            decimal resultado = caixa.CalculoJurosEmprestimo(valor, parcelamento);

            Assert.Equal(res, resultado);

        }
    }
}