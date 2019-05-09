namespace DFe.Net.Provider.Domain.NFe
{
    public class ProdutoEspecificoCombustivel : ProdutoEspecifico
    {
        /// <summary>
        ///     LA02 - Código de produto da ANP
        /// Versão 3.00
        /// Versão 4.00
        /// </summary>
        public string CodigoProdutoANP { get; set; }

        /// <summary>
        ///     LA03 - Percentual de Gás Natural para o produto GLP (cProdANP=210203001)
        /// Versão 3.00
        /// </summary>
        public decimal? PercentualGasNatural { get; set; }

        /// <summary>
        /// LA03 - Descrição do produto conforme ANP
        /// Versão 4.00
        /// </summary>
        public string DescricaoANP { get; set; }

        /// <summary>
        /// LA03a - Percentual do GLP derivado do petróleo no produto GLP (cProdANP=210203001)
        /// Versão 4.00
        /// </summary>
        public decimal? PercentualGLP { get; set; }

        /// <summary>
        /// LA03b - Percentual de Gás Natural Nacional – GLGNn para o produto GLP (cProdANP= 210203001)
        /// Versão 4.00
        /// </summary>
        public decimal? PercentualGasNaturalNacional { get; set; }

        /// <summary>
        /// LA03c - Percentual de Gás Natural Importado – GLGNi para o produto GLP (cProdANP= 210203001)
        /// Versão 4.00
        /// </summary>
        public decimal? PercentualGasNaturalImportado { get; set; }

        /// <summary>
        /// LA03d - Valor de partida (cProdANP=210203001)
        /// Versão 4.00
        /// </summary>
        public decimal? ValorPartida { get; set; }

        /// <summary>
        ///     LA04 - Código de autorização / registro do CODIF
        /// </summary>
        public string CODIF { get; set; }

        /// <summary>
        ///     LA05 - Quantidade de combustível faturada à temperatura ambiente
        /// </summary>
        public decimal? QuantidadeCombustivelTemperaturaAmbiente { get; set; }

        /// <summary>
        ///     LA06 - Sigla da UF de consumo
        /// </summary>
        public string UFConsumo { get; set; }

        /// <summary>
        ///     LA07 - Informações da CIDE
        /// </summary>
        public CIDE CIDE { get; set; }

        /// <summary>
        /// LA11 - Informações do grupo de “encerrante”
        /// </summary>
        public Encerrante Encerrante { get; set; }

        public override string NomeProdutoEspecifico()
        {
            return "Combustível";
        }
    }
}
