using DFe.Net.Provider.Domain.Enums;
using DFe.Net.Provider.Domain.NFe;
using NFe.Classes.Servicos.Tipos;
using NFe.Servicos;
using System;

namespace DFe.Net.Provider.NFe
{
    public class NFe : NFeProvider
    {
        public override Versao Versao { get; set; }
        public override IdentificacaoBase Identificacao { get; set; }
        public override Emitente Emitente { get; set; }
        public override Destinatario Destinatario { get; set; }

        public override RetornoNFe Emitir()
        {
            var servicoNFe = new ServicosNFe(null/*_configuracoes.CfgServico*/);
            var retornoEnvio = servicoNFe.NFeAutorizacao(Convert.ToInt32(Identificacao.Serie), IndicadorSincronizacao.Sincrono, null /*new List<Classes.NFe> { _nfe }*/, false);
            //Para consumir o serviço de forma síncrona, use a linha abaixo:
            //var retornoEnvio = servicoNFe.NFeAutorizacao(Convert.ToInt32(lote), IndicadorSincronizacao.Sincrono, new List<Classes.NFe> { _nfe }, true/*Envia a mensagem compactada para a SEFAZ*/);

            return null;
        }


    }
}
