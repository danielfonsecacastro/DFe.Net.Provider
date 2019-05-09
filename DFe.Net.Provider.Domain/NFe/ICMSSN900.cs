using DFe.Net.Provider.Domain.NFe.Enums;

namespace DFe.Net.Provider.Domain.NFe
{
    public class ICMSSN900 : ICMSBase
    {
        /// <summary>
        ///     N11 - Origem da Mercadoria
        /// </summary>
        public OrigemMercadoria OrigemMercadoria { get; set; }

        /// <summary>
        ///     N12a - Código de Situação da Operação – Simples Nacional
        /// </summary>
        public CsosnIcms CSOSN { get; set; }

        /// <summary>
        ///     N13 - Modalidade de determinação da BC do ICMS
        /// </summary>
        public DeterminacaoBaseIcms? ModalidadeDeterminacaoBC { get; set; }

        /// <summary>
        ///     N15 - Valor da BC do ICMS
        /// </summary>
        public decimal? ValorBC { get; set; }

        /// <summary>
        ///     N14 - Percentual de redução da BC
        /// </summary>
        public decimal? PercentualReducaoBC { get; set; }

        /// <summary>
        ///     N16 - Alíquota do imposto
        /// </summary>
        public decimal? Aliquota { get; set; }

        /// <summary>
        ///     N17 - Valor do ICMS
        /// </summary>
        public decimal? Valor { get; set; }

        /// <summary>
        ///     N18 - Modalidade de determinação da BC do ICMS ST
        /// </summary>
        public DeterminacaoBaseIcmsSt? ModalidadeBCST { get; set; }

        /// <summary>
        ///     N19 - Percentual da margem de valor Adicionado do ICMS ST
        /// </summary>
        public decimal? PercentualValorAdicionaadoST { get; set; }

        /// <summary>
        ///     N20 - Percentual da Redução de BC do ICMS ST
        /// </summary>
        public decimal? PercentualReducaoBCST { get; set; }

        /// <summary>
        ///     N21 - Valor da BC do ICMS ST
        /// </summary>
        public decimal? ValorBCST { get; set; }

        /// <summary>
        ///     N22 - Alíquota do imposto do ICMS ST
        /// </summary>
        public decimal? AliquotaICMSST { get; set; }

        /// <summary>
        ///     N23 - Valor do ICMS ST
        /// </summary>
        public decimal? ValorICMSST { get; set; }

        /// <summary>
        /// N23a - Valor da Base de Cálculo do FCP retido por Substituição Tributária
        /// Versão 4.00
        /// </summary>
        public decimal? ValorBCFCPST { get; set; }

        /// <summary>
        /// N23b - Percentual do FCP retido por Substituição Tributária
        /// Versão 4.00
        /// </summary>
        public decimal? PercentualFCPST { get; set; }

        /// <summary>
        /// N23d - Valor do FCP retido por Substituição Tributária
        /// Versão 4.00
        /// </summary>
        public decimal? ValorFCPST { get; set; }

        /// <summary>
        ///     N29 - pCredSN - Alíquota aplicável de cálculo do crédito (Simples Nacional).
        /// </summary>
        public decimal? AliquotaCreditoSN { get; set; }

        /// <summary>
        ///     N30 - Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (Simples Nacional)
        /// </summary>
        public decimal? ValorCreditoICMSSN { get; set; }

        public override string IdentificacaoICMS()
        {
            return "N10h (ICMSSN900) - Grupo CRT=1 – Simples Nacional e CSOSN=900";
        }
    }
}
