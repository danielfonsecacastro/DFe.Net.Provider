using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    /// Versão 3.10
    /// Versão 4.00
    /// </summary>
    public enum ModalidadeFrete
    {
        /// <summary>
        /// <para>0=Por conta do emitente [NFe 3.10]</para>
        /// <para>0=Contratação do Frete por conta do Remetente (CIF) [NFe 4.00]</para>
        /// </summary>
        [Description("Contratação do Frete por conta do Remetente (CIF)")]
        ContaEmitenteOuContaRemetente = 0, // Versão 3.1 ou 4.00 com objetivos diferentes e claro

        /// <summary>
        /// <para>1=Por conta do destinatário/remetente [NFe 3.10]</para>
        /// <para>1=Contratação do Frete por conta do Destinatário (FOB) [NFe 4.00]</para>
        /// </summary>
        [Description("Contratação do Frete por conta do Destinatário (FOB)")]
        ContaDestinatario = 1,

        /// <summary>
        /// <para>2=Por conta de terceiros [NFe 3.10]</para>
        /// <para>2=Contratação do Frete por conta de Terceiros [NFe 4.00]</para>
        /// </summary>
        [Description("Contratação do Frete por conta de Terceiros")]
        ContaTerceiros = 2,

        /// <summary>
        /// 3=Transporte Próprio por conta do Remetente [NFe 4.00]
        /// </summary>
        [Description("Transporte Próprio por conta do Remetente")]
        ProprioContaRemente = 3,

        /// <summary>
        /// 4=Transporte Próprio por conta do Destinatário [NFe 4.00]
        /// </summary>
        [Description("Transporte Próprio por conta do Destinatário")]
        ProprioContaDestinatario = 4,

        /// <summary>
        /// <para>9=Sem frete [NFe 3.10]</para>
        /// <para>9=Sem Ocorrência de Transporte [NFe 4.00]</para>
        /// </summary>
        [Description("Sem Ocorrência de Transporte")]
        SemFrete = 9
    }
}
