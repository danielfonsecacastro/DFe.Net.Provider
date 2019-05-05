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
            _nota400 = new GerarNotaNF400()
                .Identificacao(IdentificacaoFactory.Gerar(TipoIdentificacao.Padrao400));
        }

        [Test]
        public void DeveriaGerarChaveAcessoCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.ChaveAcesso.Should().NotBeNull();
        }

        [Test]
        public void DeveriaGerarDataEmissaoCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.DataEmissao.Should()
                .HaveDay(DateTime.Now.Day).And
                .HaveMonth(DateTime.Now.Month).And
                .HaveYear(DateTime.Now.Year);
        }

        [Test]
        public void DeveriaGerarDataSaidaEntradaCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.DataSaidaEntrada.Should()
                .HaveDay(DateTime.Now.Day).And
                .HaveMonth(DateTime.Now.Month).And
                .HaveYear(DateTime.Now.Year);
        }

        [Test]
        public void DeveriaGerarConsumidorFinalCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.ConsumidorFinal.Should().Be(ConsumidorFinal.Normal);
        }

        [Test]
        public void DeveriaGerarFinalidadeCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.Finalidade.Should().Be(Finalidade.Normal);
        }

        [Test]
        public void DeveriaGerarModeloCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.Modelo.Should().Be(ModeloDocumento.NFe);
        }

        [Test]
        public void DeveriaGerarNaturezaOperacaoCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.NaturezaOperacao.Should().Be(NaturezaOperacao.Venda);
        }

        [Test]
        public void DeveriaGerarPresencaCompradorCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.PresencaComprador.Should().Be(PresencaComprador.Presencial);
        }

        [Test]
        public void DeveriaGerarSerieCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.Serie.Should().Be(1);
        }

        [Test]
        public void DeveriaGerarTipoAmbienteCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.TipoAmbiente.Should().Be(TipoAmbiente.Producao);
        }

        [Test]
        public void DeveriaGerarVersaoAplicativoCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.VersaoAplicativo.Should().Be("4.0");
        }

        [Test]
        public void DeveriaGerarTipoImpressaoCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.TipoImpressao.Should().Be(TipoImpressao.DanfeNormalRetrato);
        }

        [Test]
        public void DeveriaGerarTipoEmissaoCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.TipoEmissao.Should().Be(TipoEmissao.Normal);
        }

        [Test]
        public void DeveriaGerarTipoOperacaoCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.TipoOperacao.Should().Be(TipoOperacao.Saida);
        }

        [Test]
        public void DeveriaGerarProcessoEmissaoCorretamente()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.ProcessoEmissao.Should().Be(ProcessoEmissao.AplicativoContribuinte);
        }

        [Test]
        public void NaoDeveriaGerarCodigoMunicipio()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.CodigoMunicipio.Should().Be(0);
        }

        [Test]
        public void NaoDeveriaGerarDataContigencia()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.DataContigencia.Should().Be(DateTimeOffset.MinValue);
        }

        [Test]
        public void NaoDeveriaGerarDestinoOperacao()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.DestinoOperacao.Should().BeNull();
        }

        [Test]
        public void NaoDeveriaGerarDigitoVerificador()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.DigitoVerificador.Should().Be(0);
        }

        [Test]
        public void NaoDeveriaGerarEstado()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.Estado.Should().Be(0);
        }

        [Test]
        public void NaoDeveriaGerarIndicadorPagamento()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.IndicadorPagamento.Should().BeNull();
        }

        [Test]
        public void NaoDeveriaGerarJustificativa()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.Justificativa.Should().BeNull();
        }

        [Test]
        public void NaoDeveriaGerarNumero()
        {
            var resultado = _nota400.Gerar();

            resultado.Identificacao.Numero.Should().Be(0);
        }
    }
}
