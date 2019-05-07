using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.Enums
{
    public enum NaturezaOperacao
    {
        [Description("Venda")]
        Venda,

        [Description("Compra")]
        Compra,

        [Description("Transferência")]
        Transferencia,

        [Description("Devolução")]
        Devolucao,

        [Description("Importação")]
        Importacao,

        [Description("Consignação")]
        Consignacao,

        [Description("Remessa")]
        Remessa
    }
}
