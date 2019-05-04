using DFe.Net.Facade.Domain.Enums;
using System;

namespace DFe.Net.Facade.Domain.Entities
{
    /// <summary>
    /// Identificação da Nota Fiscal eletrônica
    /// </summary>
    public class Identificacao
    {
        /// <summary>
        ///     B02 - Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE.
        /// </summary>
        public Estado Estado { get; set; }

        /// <summary>
        ///     B04 - Descrição da Natureza da Operação
        /// </summary>
        public ChaveAcesso ChaveAcesso { get; set; }

        /// <summary>
        ///     B04 - Descrição da Natureza da Operação
        /// </summary>
        public NaturezaOperacao NaturezaOperacao { get; set; }

        /// <summary>
        ///     B05 - Indicador da forma de pagamento
        ///     Versão 3.10
        ///     Versão 4.00 removido
        /// </summary>
        public IndicadorPagamento? IndicadorPagamento { get; set; }

        /// <summary>
        ///     B06 - Modelo do Documento Fiscal
        /// </summary>
        public ModeloDocumento Modelo { get; set; }

        /// <summary>
        ///     B07 - Série do Documento Fiscal
        ///     <para>série normal 0-889</para>
        ///     <para>Avulsa Fisco 890-899</para>
        ///     <para>SCAN 900-999</para>
        /// </summary>
        public int Serie { get; set; }

        /// <summary>
        ///     B08 - Número do Documento Fiscal
        /// </summary>
        public long Numero { get; set; }

        /// <summary>
        ///     B09 - Data de emissão do Documento Fiscal - V2.00
        /// </summary>
        public DateTime DataEmissao { get; set; }

        /// <summary>
        ///     B10 - Data de Saída ou da Entrada da Mercadoria/Produto - V2.00
        /// </summary>
        public DateTime? DataSaidaEntrada { get; set; }

        /// <summary>
        ///     B11 - Tipo do Documento Fiscal
        /// </summary>
        public TipoOperacao Tipo { get; set; }

        /// <summary>
        ///     B11a - Identificador de Local de destino da operação
        /// </summary>
        public DestinoOperacao? DestinoOperacao { get; set; }

        /// <summary>
        ///     B12 - Código do Município de Ocorrência do Fato Gerador (utilizar a tabela do IBGE)
        /// </summary>
        public long CodigoMunicipio { get; set; }

        /// <summary>
        ///     B21 - Formato de impressão do DANFE
        /// </summary>
        public TipoImpressao TipoImpressao { get; set; }

        /// <summary>
        ///     B22 - Tipo de Emissão da NF-e
        /// </summary>
        public TipoEmissao TipoEmissao { get; set; }

        /// <summary>
        ///     B23 - Digito Verificador da Chave de Acesso da NF-e
        /// </summary>
        public int DigitoVerificador { get; set; }

        /// <summary>
        ///     B24 - Identificação do Ambiente
        /// </summary>
        public TipoAmbiente TipoAmbiente { get; set; }

        /// <summary>
        ///     B25a - Finalidade da emissão da NF-e
        /// </summary>
        public Finalidade Finalidade { get; set; }

        /// <summary>
        ///     B25a - Indica operação com consumidor final
        /// </summary>
        public ConsumidorFinal? ConsumidorFinal { get; set; }

        /// <summary>
        ///     B25b - Indicador de presença do comprador no estabelecimento comercial no momento da operação
        /// </summary
        public PresencaComprador? PresencaComprador { get; set; }

        /// <summary>
        ///     B26 - Processo de emissão utilizado com a seguinte codificação:
        /// </summary>
        public ProcessoEmissao ProcessoEmissao { get; set; }

        /// <summary>
        ///     B27 - versão do aplicativo utilizado no processo de emissão
        /// </summary>
        public string VersaoAplicativo { get; set; }


        /// <summary>
        ///     B28 - Informar apenas para tpEmis diferente de 1
        ///     <para>
        ///         Informar a data e hora de entrada em contingência
        ///     </para>
        /// </summary>
        public DateTimeOffset DataContigencia { get; set; }

        /// <summary>
        ///     B29 - Justificativa da entrada em contingência
        /// </summary>
        public string Justificativa { get; set; }

    }
}
