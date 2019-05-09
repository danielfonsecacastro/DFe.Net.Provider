using System.ComponentModel;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     <para>0 – Preço tabelado ou máximo  sugerido;</para>
    ///     <para>1 - Lista Negativa (valor);</para>
    ///     <para>2 - Lista Positiva (valor);</para>
    ///     <para>3 - Lista Neutra (valor);</para>
    ///     <para>4 - Margem Valor Agregado (%);</para>
    ///     <para>5 - Pauta (valor);</para>
    /// </summary>
    public enum DeterminacaoBaseIcmsSt
    {
        /// <summary>
        /// 0 – Preço tabelado ou máximo  sugerido
        /// </summary>
        [Description("Preço tabelado ou máximo  sugerido")]
        DbisPrecoTabelado = 0,

        /// <summary>
        /// 1 - Lista Negativa (valor)
        /// </summary>
        [Description("Lista Negativa (valor)")]
        DbisListaNegativa = 1,

        /// <summary>
        /// 2 - Lista Positiva (valor)
        /// </summary>
        [Description("Lista Positiva (valor)")]
        DbisListaPositiva = 2,

        /// <summary>
        /// 3 - Lista Neutra (valor)
        /// </summary>
        [Description("Lista Neutra (valor)")]
        DbisListaNeutra = 3,

        /// <summary>
        /// 4 - Margem Valor Agregado (%)
        /// </summary>
        [Description("Margem Valor Agregado (%)")]
        DbisMargemValorAgregado = 4,

        /// <summary>
        /// 5 - Pauta (valor)
        /// </summary>
        [Description("Pauta (valor)")]
        DbisPauta = 5
    }
}
