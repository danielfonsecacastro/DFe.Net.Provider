using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Facade.Domain.Enums
{
    /// <summary>
    ///     Indicador da forma de pagamento
    ///     <para>0 – pagamento à vista;</para>
    ///     <para>1 – pagamento à prazo;</para>
    ///     <para>2 - outros.</para>
    /// </summary>
    public enum IndicadorPagamento
    {

        [Description("Pagamento à vista")]
        Vista = 0,

        [Description("Pagamento à prazo")]
        Prazo = 1,

        [Description("Outros")]
        Outras = 2
    }
}
