using System.ComponentModel;

namespace DFe.Net.Provider.Domain.Enums
{
    public enum DestinoOperacao
    {
        [Description("Interna")]
        Interna = 1,

        [Description("Interstadual")]
        Interestadual = 2,

        [Description("Exterior")]
        Exterior = 3
    }
}
