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

        //cUF = estado.SiglaParaEstado(_configuracoes.EnderecoEmitente.UF),
        //        natOp = "VENDA",
        //        mod = modelo,
        //        serie = 1,
        //        nNF = numero,
        //        tpNF = TipoNFe.tnSaida,
        //        cMunFG = _configuracoes.EnderecoEmitente.cMun,
        //        tpEmis = _configuracoes.CfgServico.tpEmis,
        //        tpImp = TipoImpressao.tiRetrato,
        //        cNF = "1234",
        //        tpAmb = _configuracoes.CfgServico.tpAmb,
        //        finNFe = FinalidadeNFe.fnNormal,
        //        verProc = "3.000"
    }
}
