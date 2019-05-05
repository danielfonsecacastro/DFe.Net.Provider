using DFe.Net.Facade.Domain.Enums;
using DFe.Net.Facade.Domain.Factories;
using DFe.Net.Facade.Domain.Fluent;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace NotaNF400Testes
{
    public class IdentificacaoPadraoTestes
    {
        private IGerarNota _nota400;

        [SetUp]
        public void Setup()
        {
            _nota400 = new GerarNotaNF400();
        }

        [Test]
        public void DeveGerarChaveAcessoCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.ChaveAcesso.Should().NotBeNull();
        }

        [Test]
        public void DeveGerarDataEmissaoCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.DataEmissao.Should()
                .HaveDay(DateTime.Now.Day).And
                .HaveMonth(DateTime.Now.Month).And
                .HaveYear(DateTime.Now.Year);
        }

        [Test]
        public void DeveGerarDataSaidaEntradaCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.DataSaidaEntrada.Should()
                .HaveDay(DateTime.Now.Day).And
                .HaveMonth(DateTime.Now.Month).And
                .HaveYear(DateTime.Now.Year);
        }

        [Test]
        public void DeveGerarConsumidorFinalCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.ConsumidorFinal.Should().Be(ConsumidorFinal.Normal);
        }

        [Test]
        public void DeveGerarFinalidadeCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.Finalidade.Should().Be(Finalidade.Normal);
        }

        [Test]
        public void DeveGerarModeloCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.Modelo.Should().Be(ModeloDocumento.NFe);
        }

        [Test]
        public void DeveGerarNaturezaOperacaoCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.NaturezaOperacao.Should().Be(NaturezaOperacao.Venda);
        }

        [Test]
        public void DeveGerarPresencaCompradorCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.PresencaComprador.Should().Be(PresencaComprador.Presencial);
        }

        [Test]
        public void DeveGerarSerieCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.Serie.Should().Be(1);
        }

        [Test]
        public void DeveGerarTipoAmbienteCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.TipoAmbiente.Should().Be(TipoAmbiente.Producao);
        }

        [Test]
        public void DeveGerarVersaoAplicativoCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.VersaoAplicativo.Should().Be("4.0");
        }

        [Test]
        public void DeveGerarTipoImpressaoCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.TipoImpressao.Should().Be(TipoImpressao.DanfeNormalRetrato);
        }

        [Test]
        public void DeveGerarTipoEmissaoCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.TipoEmissao.Should().Be(TipoEmissao.Normal);
        }

        [Test]
        public void DeveGerarTipoOperacaoCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.TipoOperacao.Should().Be(TipoOperacao.Saida);
        }

        [Test]
        public void DeveGerarProcessoEmissaoCorretamente()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.ProcessoEmissao.Should().Be(ProcessoEmissao.AplicativoContribuinte);
        }

        [Test]
        public void NaoDeveriaGerarCodigoMunicipio()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.CodigoMunicipio.Should().Be(default);
        }

        [Test]
        public void NaoDeveriaGerarDataContigencia()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();
            
            resultado.Identificacao.DataContigencia.Should().Be(default);
        }

        [Test]
        public void NaoDeveriaGerarDestinoOperacao()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.DestinoOperacao.Should().Be(default);
        }

        [Test]
        public void NaoDeveriaGerarDigitoVerificador()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.DigitoVerificador.Should().Be(default);
        }

        [Test]
        public void NaoDeveriaGerarEstado()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.Estado.Should().Be(0);
        }

        [Test]
        public void NaoDeveriaGerarIndicadorPagamento()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.IndicadorPagamento.Should().Be(default);
        }

        [Test]
        public void NaoDeveriaGerarJustificativa()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.Justificativa.Should().Be(default);
        }

        [Test]
        public void NaoDeveriaGerarNumero()
        {
            var resultado = _nota400.Identificacao(new IdentificacaoPadrao()).Gerar();

            resultado.Identificacao.Numero.Should().Be(default);
        }
    }
}
