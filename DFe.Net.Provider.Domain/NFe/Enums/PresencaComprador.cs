using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.Enums
{
    /// <summary>
    ///     Indicador de presença do comprador no estabelecimento comercial no momento da operação
    /// <para>0 - Não se aplica (por exemplo, Nota Fiscal complementar ou de ajuste);</para>
    /// <para>1 - Operação presencial;</para>
    /// <para>2 - Operação não presencial, pela Internet;</para>
    /// <para>3 - Operação não presencial, Teleatendimento;</para>
    /// <para>4 - NFC-e em operação com entrega a domicílio;</para>
    /// <para>5 - Presencial fora do Estabelecimento;</para>
    /// <para>9 - Operação não presencial, outros.</para>
    /// </summary>
    public enum PresencaComprador
    {
        [Description("Não se aplica (por exemplo, Nota Fiscal complementar ou de ajuste)")]
        Nao = 0,

        [Description("Operação presencial")]
        Presencial = 1,

        [Description("Operação não presencial, pela Internet")]
        Internet = 2,

        [Description("Operação não presencial, Teleatendimento")]
        Teleatendimento = 3,

        [Description("NFC-e em operação com entrega a domicílio")]
        EntregaDomicilio = 4,

        [Description("Presencial fora do Estabelecimento")]
        PresencialForaEstabelecimento = 5, 

        [Description("Operação não presencial, outros")]
        Outros = 9
    }
}
