using System.ComponentModel;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     1=Venda concessionária,
    ///     2=Faturamento direto para consumidor final
    ///     3=Venda direta para grandes consumidores (frotista, governo, ...)
    ///     0=Outros
    /// </summary>
    public enum TipoOperacaoProdutoVeiculo
    {
        [Description("Outros")]
        Outros = 0,
        [Description("Venda concessionária")]
        VendaConcessionaria = 1,
        [Description("Faturamento direto para consumidor final")]
        FaturamentodiretoparaconsumidorFinal = 2,
        [Description("Venda direta para grandes consumidores (frotista, governo, ...)")]
        VendaDiretaParaGrandesConsumidores = 3
    }
}
