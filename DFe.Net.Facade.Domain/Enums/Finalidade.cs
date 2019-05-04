using System.ComponentModel;

namespace DFe.Net.Facade.Domain.Enums
{
    /// <summary>
    ///     Finalidade da emissão da NF-e
    ///     <para>1 - NFe normal</para>
    ///     <para>2 - NFe complementar</para>
    ///     <para>3 - NFe de ajuste</para>
    ///     <para>4 - Devolução/Retorno</para>
    /// </summary>
    public enum Finalidade
    {
        [Description("NF-e normal")]
        Normal = 1,

        [Description("NF-e complementar")]
        Complementar = 2,

        [Description("NF-e de ajuste")]
        Ajuste = 3,

        [Description("Devolução de mercadoria")]
        Devolucao = 4
    }
}
