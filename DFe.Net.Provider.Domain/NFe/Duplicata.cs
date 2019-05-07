using System;

namespace DFe.Net.Provider.Domain.NFe
{
    public class Duplicata
    {
        /// <summary>
        ///     Y08 - Número da Duplicata
        /// </summary>
        public string NumeroDuplicata { get; set; }

        /// <summary>
        ///     Y09 - Data de vencimento
        /// </summary>
        public DateTime? DataVencimento { get; set; }

        /// <summary>
        ///     Y10 - Valor da duplicata
        /// </summary>
        public decimal ValorDuplicata { get; set; }
    }
}
