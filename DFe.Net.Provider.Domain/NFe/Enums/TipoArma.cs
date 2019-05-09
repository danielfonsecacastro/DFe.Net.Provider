using System.ComponentModel;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     0=Uso permitido; 1=Uso restrito;
    /// </summary>
    public enum TipoArma
    {
        [Description("Uso permitido")] UsoPermitido = 0,
        [Description("Uso restrito")] UsoRestrito = 1
    }
}
