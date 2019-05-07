namespace DFe.Net.Provider.Domain.NFe
{
    public class Fatura
    {
        /// <summary>
        ///     Y03 - Número da Fatura
        /// </summary>
        public string NumeroFatura { get; set; }

        /// <summary>
        ///     Y04 - Valor Original da Fatura
        /// </summary>
        public decimal? ValorOriginal { get; set; }

        /// <summary>
        ///     Y05 - Valor do desconto
        /// </summary>
        public decimal? ValorDesconto { get; set; }

        /// <summary>
        ///     Y06 - Valor Líquido da Fatura
        /// </summary>
        public decimal? ValorLiquido { get; set; }
    }
}
