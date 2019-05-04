using System.ComponentModel;

namespace DFe.Net.Facade.Domain.Enums
{
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
