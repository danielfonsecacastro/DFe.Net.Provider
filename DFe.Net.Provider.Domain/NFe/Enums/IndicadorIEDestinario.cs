using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.Enums
{
    /// <summary>
    ///     <para>1 – Contribuinte ICMS;</para>
    ///     <para>2 – Contribuinte isento de inscrição;</para>
    ///     <para>9 – Não Contribuinte</para>
    /// </summary>
    public enum IndicadorIEDestinario
    {
        [Description("Contribuinte ICMS")]
        ContribuinteICMS = 1,

        [Description("Contribuinte isento de inscrição")]
        Isento = 2,

        [Description("Não Contribuinte")]
        NaoContribuinte = 9
    }
}
