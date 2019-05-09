using System.ComponentModel;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     <para>0-Nacional exceto as indicadas nos códigos 3, 4, 5 e 8;</para>
    ///     <para>1-Estrangeira - Importação direta;</para>
    ///     <para>2-Estrangeira - Adquirida no mercado interno;</para>
    ///     <para>3-Nacional, conteudo superior 40% e inferior ou igual a 70%;</para>
    ///     <para>4-Nacional, processos produtivos básicos;</para>
    ///     <para>5-Nacional, conteudo inferior 40%;</para>
    ///     <para>6-Estrangeira - Importação direta, com similar nacional, lista CAMEX;</para>
    ///     <para>7-Estrangeira - mercado interno, sem simular,lista CAMEX;</para>
    ///     <para>8-Nacional, Conteúdo de Importação superior a 70%.</para>
    /// </summary>
    public enum OrigemMercadoria
    {
        /// <summary>
        /// 0-Nacional exceto as indicadas nos códigos 3, 4, 5 e 8
        /// </summary>
        [Description("0")]
        Nacional = 0,

        /// <summary>
        /// 2-Estrangeira - Adquirida no mercado interno
        /// </summary>
        [Description("Estrangeira - Adquirida no mercado interno")]
        EstrangeiraImportacaoDireta = 1,

        /// <summary>
        /// 3-Nacional, conteudo superior 40% e inferior ou igual a 70%
        /// </summary>
        [Description("Nacional, conteudo superior 40% e inferior ou igual a 70%")]
        EstrangeiraAdquiridaBrasil = 2,

        /// <summary>
        /// 3-Nacional, conteudo superior 40% e inferior ou igual a 70%
        /// </summary>
        [Description("Nacional, conteudo superior 40% e inferior ou igual a 70%")]
        NacionalConteudoImportacaoSuperior40 = 3,

        /// <summary>
        /// 4-Nacional, processos produtivos básicos
        /// </summary>
        [Description("Nacional, processos produtivos básicos")]
        NacionalProcessosBasicos = 4,

        /// <summary>
        /// 5-Nacional, conteudo inferior 40%
        /// </summary>
        [Description("Nacional, conteudo inferior 40%")]
        NacionalConteudoImportacaoInferiorIgual40 = 5,

        /// <summary>
        /// 6-Estrangeira - Importação direta, com similar nacional, lista CAMEX
        /// </summary>
        [Description("Estrangeira - Importação direta, com similar nacional, lista CAMEX")]
        EstrangeiraImportacaoDiretaSemSimilar = 6,

        /// <summary>
        /// 7-Estrangeira - mercado interno, sem simular,lista CAMEX
        /// </summary>
        [Description("Estrangeira - mercado interno, sem simular,lista CAMEX")]
        EstrangeiraAdquiridaBrasilSemSimilar = 7,

        /// <summary>
        /// 8-Nacional, Conteúdo de Importação superior a 70%
        /// </summary>
        [Description("Nacional, Conteúdo de Importação superior a 70%")]
        NacionalConteudoImportacaoSuperior70 = 8
    }
}
