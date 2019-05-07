using System.Collections.Generic;

namespace DFe.Net.Provider.Domain.NFe
{
    public class Cobranca
    {
        /// <summary>
        ///     Y02 - Grupo Fatura
        /// </summary>
        public Fatura Fatura { get; set; }

        /// <summary>
        ///     Y07 - Grupo Duplicata
        ///     <para>Ocorrência: 0-120</para>
        /// </summary>
        public List<Duplicata> Duplicata { get; set; }
    }
}
