using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     <para>0 – o valor do item (vProd) não compõe o valor total da NF-e (vProd)</para>
    ///     <para>1  – o valor do item (vProd) compõe o valor total da NF-e (vProd)</para>
    /// </summary>
    public enum IndicadorTotal
    {
        [Description("O Valor do Item não compõe o valor total da NF-e")] ValorDoItemNaoCompoeTotalNF = 0,
        [Description("O Valor do Item compõe o valor total da NF-e")] ValorDoItemCompoeTotalNF = 1
    }
}
