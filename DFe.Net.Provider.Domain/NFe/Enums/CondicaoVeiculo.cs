using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     1=Acabado; 2=Inacabado; 3=Semiacabado
    /// </summary>
    public enum CondicaoVeiculo
    {
        [Description("Acabado")] Acabado = 1,
        [Description("Inacabado")] Inacabado = 2,
        [Description("Semiacabado")] Semiacabado = 3
    }
}
