using DFe.Net.Provider.Domain.Enums;
using DFe.Net.Provider.Domain.Factories;
using DFe.Net.Provider.Domain.NFe;
using FluentAssertions;
using System;
using Xunit;

namespace NotaNF400Testes
{
    public class IdentificacaoPadraoTestes
    {
        private IdentificacaoBase _identificao;

        public IdentificacaoPadraoTestes()
        {
            _identificao = IdentificacaoFactory.Gerar(TipoIdentificacao.Padrao400);
        }

        [Fact]
        public void DeveriaGerarChaveAcessoCorretamente()
        {
            _identificao.ChaveAcesso.Should().NotBeNull();
        }

        [Fact]
        public void DeveriaGerarDataEmissaoCorretamente()
        {
            _identificao.DataEmissao.Should()
                .HaveDay(DateTime.Now.Day).And
                .HaveMonth(DateTime.Now.Month).And
                .HaveYear(DateTime.Now.Year);
        }

        [Fact]
        public void DeveriaGerarDataSaidaEntradaCorretamente()
        {
            _identificao.DataSaidaEntrada.Should()
                .HaveDay(DateTime.Now.Day).And
                .HaveMonth(DateTime.Now.Month).And
                .HaveYear(DateTime.Now.Year);
        }

        [Fact]
        public void DeveriaGerarConsumidorFinalCorretamente()
        {
            _identificao.ConsumidorFinal.Should().Be(ConsumidorFinal.Normal);
        }

        [Fact]
        public void DeveriaGerarFinalidadeCorretamente()
        {
            _identificao.Finalidade.Should().Be(Finalidade.Normal);
        }

        [Fact]
        public void DeveriaGerarModeloCorretamente()
        {
            _identificao.Modelo.Should().Be(ModeloDocumento.NFe);
        }

        [Fact]
        public void DeveriaGerarNaturezaOperacaoCorretamente()
        {
            _identificao.NaturezaOperacao.Should().Be(NaturezaOperacao.Venda);
        }

        [Fact]
        public void DeveriaGerarPresencaCompradorCorretamente()
        {
            _identificao.PresencaComprador.Should().Be(PresencaComprador.Presencial);
        }

        [Fact]
        public void DeveriaGerarSerieCorretamente()
        {
            _identificao.Serie.Should().Be(1);
        }

        [Fact]
        public void DeveriaGerarTipoAmbienteCorretamente()
        {
            _identificao.TipoAmbiente.Should().Be(TipoAmbiente.Producao);
        }

        [Fact]
        public void DeveriaGerarVersaoAplicativoCorretamente()
        {
            _identificao.VersaoAplicativo.Should().Be("4.0");
        }

        [Fact]
        public void DeveriaGerarTipoImpressaoCorretamente()
        {
            _identificao.TipoImpressao.Should().Be(TipoImpressao.DanfeNormalRetrato);
        }

        [Fact]
        public void DeveriaGerarTipoEmissaoCorretamente()
        {
            _identificao.TipoEmissao.Should().Be(TipoEmissao.Normal);
        }

        [Fact]
        public void DeveriaGerarTipoOperacaoCorretamente()
        {
            _identificao.TipoOperacao.Should().Be(TipoOperacao.Saida);
        }

        [Fact]
        public void DeveriaGerarProcessoEmissaoCorretamente()
        {
            _identificao.ProcessoEmissao.Should().Be(ProcessoEmissao.AplicativoContribuinte);
        }

        [Fact]
        public void NaoDeveriaGerarCodigoMunicipio()
        {
            _identificao.CodigoMunicipio.Should().Be(0);
        }

        [Fact]
        public void NaoDeveriaGerarDataContigencia()
        {
            _identificao.DataContigencia.Should().Be(DateTimeOffset.MinValue);
        }

        [Fact]
        public void NaoDeveriaGerarDestinoOperacao()
        {
            _identificao.DestinoOperacao.Should().BeNull();
        }

        [Fact]
        public void NaoDeveriaGerarDigitoVerificador()
        {
            _identificao.DigitoVerificador.Should().Be(0);
        }

        [Fact]
        public void NaoDeveriaGerarEstado()
        {
            _identificao.Estado.Should().Be(0);
        }

        [Fact]
        public void NaoDeveriaGerarIndicadorPagamento()
        {
            _identificao.IndicadorPagamento.Should().BeNull();
        }

        [Fact]
        public void NaoDeveriaGerarJustificativa()
        {
            _identificao.Justificativa.Should().BeNull();
        }

        [Fact]
        public void NaoDeveriaGerarNumero()
        {
            _identificao.Numero.Should().Be(0);
        }
    }
}
