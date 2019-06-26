using System;
using System.Collections.Generic;
using System.Text;

namespace BoletosSharp
{
    /// <summary>
    /// Representa um boleto já gerado, com todas as informações preenchidias
    /// </summary>
    public class Boleto
    {
        internal Boleto()
        {

        }

        /// <summary>
        /// Código de barras, no formato númerico decimal
        /// </summary>
        public string CodigoBarra { get; set; }
        
        /// <summary>
        /// Carteira do convenio bancario
        /// </summary>
        public string Carteira { get; set; }

        /// <summary>
        /// Nosso número, já formatado
        /// </summary>
        public string NossoNumero { get; set; }
    }
}
