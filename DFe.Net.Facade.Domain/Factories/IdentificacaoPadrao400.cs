using DFe.Net.Facade.Domain.NFe;
using System;

namespace DFe.Net.Facade.Domain.Factories
{
    public class IdentificacaoPadrao400 : IdentificacaoBase
    {
        public IdentificacaoPadrao400()
        {
            ChaveAcesso = new ChaveAcesso();
            DataEmissao = DateTime.Now;
            DataSaidaEntrada = DateTime.Now;
            ConsumidorFinal = Enums.ConsumidorFinal.Normal;
            Finalidade = Enums.Finalidade.Normal;
            Modelo = Enums.ModeloDocumento.NFe;
            NaturezaOperacao = Enums.NaturezaOperacao.Venda;
            PresencaComprador = Enums.PresencaComprador.Presencial;
            Serie = 1;
            TipoAmbiente = Enums.TipoAmbiente.Producao;
            VersaoAplicativo = "4.0";
            TipoImpressao = Enums.TipoImpressao.DanfeNormalRetrato;
            TipoEmissao = Enums.TipoEmissao.Normal;
            TipoOperacao = Enums.TipoOperacao.Saida;
            ProcessoEmissao = Enums.ProcessoEmissao.AplicativoContribuinte;
        }
    }
}
