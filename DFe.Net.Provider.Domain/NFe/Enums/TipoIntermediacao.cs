using System.ComponentModel;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     1=Importação por conta própria;
    ///     2=Importação por conta e ordem;
    ///     3=Importação por encomenda;
    /// </summary>
    public enum TipoIntermediacao
    {
        /// <summary>
        /// 1=Importação por conta própria
        /// </summary>
        [Description("Importação por conta própria")]
        ContaPropria = 1,

        /// <summary>
        /// 2=Importação por conta e ordem
        /// </summary>
        [Description("Importação por conta e ordem")]
        ContaeOrdem = 2,

        /// <summary>
        /// 3=Importação por encomenda
        /// </summary>
        [Description("Importação por encomenda")]
        PorEncomenda = 3
    }
}
