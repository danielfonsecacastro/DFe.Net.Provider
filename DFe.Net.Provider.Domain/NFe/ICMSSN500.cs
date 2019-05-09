using DFe.Net.Provider.Domain.NFe.Enums;

namespace DFe.Net.Provider.Domain.NFe
{
    public class ICMSSN500 : ICMSBase
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
        ///     N26 - Valor da BC do ICMS ST retido
        /// </summary>
        public decimal? ValoBCSTRetido { get; set; }

        /// <summary>
        /// N26a  - Alíquota suportada pelo Consumidor Final
        /// </summary>
        public decimal? AliquotaST { get; set; }

        public decimal? ValorICMSSubstituto { get; set; }

        /// <summary>
        ///     N27 - Valor do ICMS ST retido
        /// </summary>
        public decimal? ValorICMSSTRetido { get; set; }

        /// <summary>
        /// N27a - Valor da Base de Cálculo do FCP 
        /// Versão 4.00
        /// </summary>
        public decimal? ValorBCFCPSTRetido { get; set; }

        /// <summary>
        /// N27b - Percentual do FCP retido anteriormente por Substituição Tributária
        /// </summary>
        public decimal? PercentualFCPSTRetido { get; set; }

        /// <summary>
        /// N27d - Valor do FCP retido anteriormente por Substituição Tributária
        /// </summary>
        public decimal? ValorFCPSTRetido { get; set; }

        /// <summary>
        ///     N34 - Percentual de redução da base de cálculo efetiva 
        /// </summary>
        public decimal? PercentualReducaoBCEfetiva { get; set; }

        /// <summary>
        ///     N35 - Valor da base de cálculo efetiva 
        /// </summary>
        public decimal? ValorBCEfetiva { get; set; }

        /// <summary>
        ///     N36 - Alíquota do ICMS efetiva 
        /// </summary>
        public decimal? AliquotaICMSEfetiva { get; set; }

        /// <summary>
        ///     N37 - Valor do ICMS efetivo 
        /// </summary>
        public decimal? ValorICMSEfetivo { get; set; }

        public override string IdentificacaoICMS()
        {
            return "N10g (ICMSSN500) - Grupo CRT=1 – Simples Nacional e CSOSN = 500";
        }
    }
}
