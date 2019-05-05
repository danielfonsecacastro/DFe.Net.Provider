using DFe.Net.Facade.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Facade.Domain.NFe
{
    public class Emitente
    {
        public Emitente(Endereco endereco)
        {
            Endereco = endereco;
        }

        /// <summary>
        ///     C02 - CNPJ do emitente
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        ///     C02a - CPF do remetente
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        ///     C03 - Razão Social ou Nome do emitente
        /// </summary>
        public string RazaoSocialOuNome { get; set; }

        /// <summary>
        ///     C04 - Nome fantasia
        /// </summary>
        public string NomeFantasia { get; set; }

        /// <summary>
        ///     C05 - Grupo do Endereço do emitente
        /// </summary>
        public Endereco Endereco { get; set; }

        /// <summary>
        ///     C17 - Inscrição Estadual
        ///     <para>Campo de informação obrigatória nos casos de emissão própria (procEmi = 0, 2 ou 3).</para>
        ///     <para>
        ///         A IE deve ser informada apenas com algarismos para destinatários contribuintes do ICMS, sem caracteres de
        ///         formatação (ponto, barra, hífen, etc.);
        ///     </para>
        ///     <para>
        ///         O literal “ISENTO” deve ser informado apenas para contribuintes do ICMS que são isentos de inscrição no
        ///         cadastro de contribuintes do ICMS e estejam emitindo NF-e avulsa;
        ///     </para>
        /// </summary>
        public string IE { get; set; }

        /// <summary>
        ///     C18 - IE do Substituto Tributário
        ///     <para>Informar a IE do ST da UF de destino da mercadoria, quando houver a retenção do ICMS ST para a UF de destino.</para>
        /// </summary>
        public string IEST { get; set; }

        /// <summary>
        ///     C19 - Inscrição Municipal
        ///     <para>
        ///         Este campo deve ser informado, quando ocorrer a emissão de NF-e conjugada, com prestação de serviços sujeitos
        ///         ao ISSQN e fornecimento de peças sujeitos ao ICMS.
        ///     </para>
        /// </summary>
        public string IM { get; set; }

        /// <summary>
        ///     C20 - CNAE fiscal
        ///     <para>Este campo deve ser informado quando o campo IM (C19) for informado.</para>
        /// </summary>
        public string CNAE { get; set; }

        /// <summary>
        ///     C21 - Código de Regime Tributário
        /// </summary>
        public CRT CRT { get; set; }
    }
}
