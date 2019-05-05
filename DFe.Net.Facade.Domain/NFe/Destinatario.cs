using DFe.Net.Facade.Domain.Enums;

namespace DFe.Net.Facade.Domain.NFe
{
    public class Destinatario
    {
        public Destinatario(Endereco endereco)
        {
            EnderecoDestinatario = endereco;
        }

        /// <summary>
        ///     E02 - CNPJ do destinatário
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        ///     E03 - CPF do destinatário
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        ///     E03a - Identificador do destinatário, em caso de comprador estrangeiro
        /// </summary>
        public string IdEstrangeiro { get; set; }

        /// <summary>
        ///     E04 - Razão Social ou nome do destinatário
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        ///     E05 - Endereço do Destinatário da NF-e
        /// </summary>
        public Endereco EnderecoDestinatario { get; set; }

        /// <summary>
        ///     E16a - Indicador da IE do destinatário:
        /// </summary>
        public IndicadorIEDestinario IndicadorIEDestinario { get; set; } 

        /// <summary>
        ///     E17 - Inscrição Estadual
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
        ///     E18 - Inscrição na SUFRAMA (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob
        ///     controle da SUFRAMA)
        /// </summary>
        public string ISUF { get; set; }

        /// <summary>
        ///     E18a - Inscrição Municipal
        ///     <para>
        ///         Este campo deve ser informado, quando ocorrer a emissão de NF-e conjugada, com prestação de serviços sujeitos
        ///         ao ISSQN e fornecimento de peças sujeitos ao ICMS.
        ///     </para>
        /// </summary>
        public string IM { get; set; }

        /// <summary>
        ///     E19 - Informar o e-mail do destinatário. O campo pode ser utilizado para informar o e-mail de recepção da NF-e
        ///     indicada pelo destinatário
        /// </summary>
        public string Email { get; set; }
    }
}
