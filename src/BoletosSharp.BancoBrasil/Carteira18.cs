using System.Threading.Tasks;

namespace BoletosSharp.BancoBrasil
{
    /// <summary>
    /// Represnta carteira 18-019 do Banco do Brasil
    /// </summary>
    public class Carteira18 : CarteiraBancoBase, ICarteiraBanco
    {

        public string CodigoCarteira => "18";
        public async Task<string> GetNossoNumeroAsync(BoletoRequest request)
        {
            if (request == null)
            {
                throw new System.ArgumentNullException(nameof(request));
            }

            return await Task.Run(() =>
            {

                var nossoNumero = request.SequencialNossoNumero.ToString();
                var cedente = request.Cedente;

                //somente monta o digito verificador no nosso numero se o convenio tiver 6 posições
                if (cedente.Convenio.Length == 6)
                {
                    nossoNumero = string.Format("{0}/{1}-{2}", CodigoCarteira, nossoNumero, Mod11BancoBrasil(nossoNumero));
                }
                else
                {
                    nossoNumero = string.Format("{0}/{1}", CodigoCarteira, nossoNumero);
                }

                return nossoNumero;

            });
        }
    }
}
