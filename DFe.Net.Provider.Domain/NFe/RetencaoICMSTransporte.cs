using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public class RetencaoICMSTransporte
    {

        /// <summary>
        ///     X12 - Valor do Serviço
        /// </summary>
        public decimal ValorServico { get; set; }

        /// <summary>
        ///     X13 - BC da Retenção do ICMS
        /// </summary>
        public decimal BCRetencaoICMS { get; set; }

        /// <summary>
        ///     X14 - Alíquota da Retenção
        /// </summary>
        public decimal AliquotaICMS { get; set; }

        /// <summary>
        ///     X15 - Valor do ICMS Retido
        /// </summary>
        public decimal ValorICMS { get; set; }

        /// <summary>
        ///     X16 - CFOP
        /// </summary>
        public int CFOP { get; set; }

        /// <summary>
        ///     X17 - Código do município de ocorrência do fato gerador do ICMS do transporte
        /// </summary>
        public long CodigoMunicipio { get; set; }
    }
}
