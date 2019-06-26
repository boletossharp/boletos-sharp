using System;
using System.Threading.Tasks;

namespace BoletosSharp
{
    /// <summary>
    /// Classe responsável por gerar boletos
    /// </summary>
    public class BoletoGenerator
    {
        public async Task<Boleto> GenerateAsync(
            ICarteiraBanco carteira,
            BoletoRequest boletoRequest)
        {


            if (carteira == null)
            {
                throw new ArgumentNullException(nameof(carteira));
            }

            if (boletoRequest == null)
            {
                throw new ArgumentNullException(nameof(boletoRequest));
            }



            var boleto = new Boleto();

            var nossoNumero = await carteira.GetNossoNumeroAsync(boletoRequest);

            boleto.NossoNumero = nossoNumero;


            return boleto;
        }
    }
}
