using DFe.Net.Facade.Domain.Enums;

namespace DFe.Net.Facade.Domain.Entities
{
    public class Identificacao
    {
        public Estado Estado { get; set; }
        public NaturezaOperacao NaturezaOperacao { get; set; }
        public ModeloDocumento Modelo { get; set; }
        public int Serie { get; set; }
        public long Numero { get; set; }
        public TipoDocumentoFiscal Tipo { get; set; }
        public long CodigoMunicipio { get; set; }
        public TipoEmissao TipoEmissao { get; set; }
        public TipoImpressao TipoImpressao { get; set; }
        public string ChaveAcesso { get; set; }
        public TipoAmbiente TipoAmbiente { get; set; }
        public Finalidade Finalidade { get; set; }
        public string VersaoAplicativo { get; set; }
    }
}
