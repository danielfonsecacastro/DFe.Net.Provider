using System.ComponentModel;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     <para>0 - Margem Valor Agregado (%);</para>
    ///     <para>1 - Pauta (valor);</para>
    ///     <para>2 - Preço Tabelado Máximo (valor);</para>
    ///     <para>3 - Valor da Operação.</para>
    /// </summary>
    public enum DeterminacaoBaseIcms
    {
        /// <summary>
        /// 0 - Margem Valor Agregado (%)
        /// </summary>
        [Description("Margem Valor Agregado (%)")]
        DbiMargemValorAgregado = 0,

        /// <summary>
        /// 1 - Pauta (valor)
        /// </summary>
        [Description("Pauta (valor)")]
        DbiPauta = 1,

        /// <summary>
        /// 2 - Preço Tabelado Máximo (valor)
        /// </summary>
        [Description("Preço Tabelado Máximo (valor)")]
        DbiPrecoTabelado = 2,

        /// <summary>
        /// 3 - Valor da Operação
        /// </summary>
        [Description("Valor da Operação")]
        DbiValorOperacao = 3
    }
}
