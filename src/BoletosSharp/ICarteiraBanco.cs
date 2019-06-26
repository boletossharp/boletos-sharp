using System.Threading.Tasks;

namespace BoletosSharp
{
    public interface ICarteiraBanco
    {
        string CodigoCarteira { get; }
        Task<string> GetNossoNumeroAsync(BoletoRequest boletoRequest);

    }
}
