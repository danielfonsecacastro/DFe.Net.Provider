using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     <para>101 - Tributada pelo Simples Nacional com permissão de crédito. (v.2.0)</para>
    ///     <para>102 - Tributada pelo Simples Nacional sem permissão de crédito. </para>
    ///     <para>103 – Isenção do ICMS  no Simples Nacional para faixa de receita bruta.</para>
    ///     <para>
    ///         201 - Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por Substituição
    ///         Tributária (v.2.0)
    ///     </para>
    ///     <para>
    ///         202 - Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por Substituição
    ///         Tributária
    ///     </para>
    ///     <para>
    ///         203 -  Isenção do ICMS nos Simples Nacional para faixa de receita bruta e com cobrança do ICMS por
    ///         Substituição Tributária (v.2.0)
    ///     </para>
    ///     <para>300 – Imune.</para>
    ///     <para>400 – Não tributda pelo Simples Nacional (v.2.0)</para>
    ///     <para>500 – ICMS cobrado anterirmente por substituição tributária (substituído) ou por antecipação (v.2.0)</para>
    ///     <para>Tributação pelo ICMS 900 - Outros(v2.0)</para>
    /// </summary>
    public enum CsosnIcms
    {
        /// <summary>
        /// 101 - Tributada pelo Simples Nacional com permissão de crédito
        /// </summary>
        [Description("Tributada pelo Simples Nacional com permissão de crédito")]
        Csosn101 = 101,

        /// <summary>
        /// 102 - Tributada pelo Simples Nacional sem permissão de crédito
        /// </summary>
        [Description("Tributada pelo Simples Nacional sem permissão de crédito")]
        Csosn102 = 102,

        /// <summary>
        /// 103 – Isenção do ICMS  no Simples Nacional para faixa de receita bruta
        /// </summary>
        [Description("Isenção do ICMS  no Simples Nacional para faixa de receita bruta")]
        Csosn103 = 103,

        /// <summary>
        /// 201 - Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por Substituição Tributária 
        /// </summary>
        [Description("Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por Substituição Tributária ")]
        Csosn201 = 201,

        /// <summary>
        /// 202 - Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por Substituição Tributária
        /// </summary>
        [Description("Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por Substituição Tributária")]
        Csosn202 = 202,

        /// <summary>
        /// 203 -  Isenção do ICMS nos Simples Nacional para faixa de receita bruta e com cobrança do ICMS por Substituição Tributária 
        /// </summary>
        [Description("Isenção do ICMS nos Simples Nacional para faixa de receita bruta e com cobrança do ICMS por Substituição Tributária")]
        Csosn203 = 203,

        /// <summary>
        /// 300 – Imune
        /// </summary>
        [Description("Imune")]
        Csosn300 = 300,

        /// <summary>
        /// 400 – Não tributada pelo Simples Nacional
        /// </summary>
        [Description("Não tributada pelo Simples Nacional")]
        Csosn400 = 400,

        /// <summary>
        /// 500 – ICMS cobrado anterirmente por substituição tributária (substituído) ou por antecipação
        /// </summary>
        [Description("ICMS cobrado anterirmente por substituição tributária (substituído) ou por antecipação")]
        Csosn500 = 500,

        /// <summary>
        /// 900 - Outros
        /// </summary>
        [Description("Outros")]
        Csosn900 = 900
    }
}
