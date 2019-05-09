using DFe.Net.Provider.Domain.NFe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public class DeclaracaoImportacao
    {
        /// <summary>
        ///     I19 - Número do Documento de Importação (DI, DSI, DIRE, ...)
        /// </summary>
        public string NumeroDocumentoImportacao { get; set; }

        /// <summary>
        ///     I20 - Data de Registro do documento.
        /// </summary>
        public DateTime DataRegistroDocumento { get; set; }

        /// <summary>
        ///     I21 - Local de desembaraço
        /// </summary>
        public string LocalDesembaraco { get; set; }

        /// <summary>
        ///     I22 - Sigla da UF onde ocorreu o Desembaraço Aduaneiro
        /// </summary>
        public string UFDesembaraco { get; set; }

        /// <summary>
        ///     I23 - Data do Desembaraço Aduaneiro.
        /// </summary>
        public DateTime DataDesembaraco { get; set; }

        /// <summary>
        ///     I23a - Via de transporte internacional informada na Declaração de Importação (DI)
        /// </summary>
        public TipoTransporteInternacional tpViaTransp { get; set; }

        /// <summary>
        ///     I23b - Valor da AFRMM - Adicional ao Frete para Renovação da Marinha Mercante
        /// </summary>
        public decimal? ValorAFRMM { get; set; }

        /// <summary>
        ///     I23c - Forma de importação quanto a intermediação
        /// </summary>
        public TipoIntermediacao TipoIntermedio { get; set; }

        /// <summary>
        ///     I23d - CNPJ do adquirente ou do encomendante
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        ///     I23e - Sigla da UF do adquirente ou do encomendante
        /// </summary>
        public string UFTerceiro { get; set; }

        /// <summary>
        ///     I24 - Código do Exportador
        /// </summary>
        public string CodigoExportador { get; set; }

        /// <summary>
        ///     I25 - Adições
        /// </summary>
        public List<Adicao> Adicoes { get; set; }
    }
}
