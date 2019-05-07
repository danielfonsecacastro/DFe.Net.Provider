using System.ComponentModel;

namespace DFe.Net.Provider.Domain.Enums
{
    /// <summary>
    ///     Indica operação com Consumidor final
    ///     <para>0 - Normal;</para>
    ///     <para>1 - Consumidor final;</para>
    /// </summary>
    public enum ConsumidorFinal
    {
        [Description("Normal")]
        Normal = 0,

        [Description("Consumidor final")]
        ConsumidorFinal = 1
    }
}
