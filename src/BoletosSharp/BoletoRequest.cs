using System;

namespace BoletosSharp
{
    /// <summary>
    /// Contém as informações para que seja gerado um boleto
    /// </summary>
    public class BoletoRequest
    {
        public Cedente Cedente { get; }
        public BoletoRequest(Cedente cedente)
        {
            Cedente = cedente;
        }

        /// <summary>
        /// Data de vencimento do Boleto
        /// </summary>
        public DateTime DataVencimento { get; set; }

        /// <summary>
        /// Valor do boleto
        /// </summary>
        public decimal Valor { get; set; }


        /// <summary>
        /// Parte númerica do nosso número. 
        /// </summary>
        public long SequencialNossoNumero { get; set; }
    }
}
