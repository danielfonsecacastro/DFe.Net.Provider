using System.ComponentModel;

namespace DFe.Net.Provider.Domain.Enums
{
    /// <summary>
    ///     Processo de emissão utilizado com a seguinte codificação:
    ///     <para>0 - emissão de NF-e com aplicativo do contribuinte;</para>
    ///     <para>1 - emissão de NF-e avulsa pelo Fisco;</para>
    ///     <para>2 - emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco;</para>
    ///     <para>3- emissão de NF-e pelo contribuinte com aplicativo fornecido pelo Fisco.</para>
    /// </summary>
    public enum ProcessoEmissao
    {

        [Description("Emissão de NF-e com aplicativo do contribuinte")]
        AplicativoContribuinte = 0,

        [Description("Emissão de NF-e avulsa pelo Fisco")]
        AvulsaFisco = 1,

        [Description("Emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco")]
        AvulsaContribuinte = 2,

        [Description("Emissão de NF-e pelo contribuinte com aplicativo fornecido pelo Fisco")]
        ContribuinteAplicativoFisco = 3
    }
}
