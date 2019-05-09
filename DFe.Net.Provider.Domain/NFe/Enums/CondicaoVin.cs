using System.ComponentModel;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     Informa-se o veículo tem VIN (chassi) remarcado. R=Remarcado; N=Normal
    /// </summary>
    public enum CondicaoVin
    {
        [Description("Remarcado")] Remarcado = 'R',
        [Description("Normal")] Normal = 'N'
    }
}
