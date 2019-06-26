using BoletosSharp.BancoBrasil;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace BoletosSharp.Tests
{
    [TestClass]
    public class BancoBrasilTests
    {
        private readonly BoletoGenerator _boletoGenerator;
        private readonly Cedente _cedente;
        private readonly ICarteiraBanco _carteira;
        public BancoBrasilTests()
        {
            _boletoGenerator = new BoletoGenerator();
            _cedente = new Cedente("1234567");
            _carteira = new Carteira18();
        }
        [TestMethod]
        public async Task Carteira18_Convenio_7()
        {

            var request = new BoletoRequest(_cedente)
            {
                SequencialNossoNumero = 999
            };
            var boleto = await _boletoGenerator.GenerateAsync(
                _carteira,
                request);

            Assert.IsNotNull(boleto);
            Assert.AreEqual(boleto.NossoNumero, "18/999");
        }
    }
}
