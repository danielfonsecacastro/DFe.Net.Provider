using DFe.Net.Facade.Domain.Enums;
using DFe.Net.Facade.Domain.Factories;
using DFe.Net.Facade.Domain.Fluent;
using DFe.Net.Facade.Domain.NFe;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace NotaNF400Testes
{
    public class IdentificacaoPadraoTestes
    {
        private IdentificacaoBase _identificao;

        [SetUp]
        public void Setup()
        {
            _identificao = IdentificacaoFactory.Gerar(TipoIdentificacao.Padrao400);
        }

        [Test]
        public void DeveriaGerarChaveAcessoCorretamente()
        {
            _identificao.ChaveAcesso.Should().NotBeNull();
        }

        [Test]
        public void DeveriaGerarDataEmissaoCorretamente()
        {
            _identificao.DataEmissao.Should()
                .HaveDay(DateTime.Now.Day).And
                .HaveMonth(DateTime.Now.Month).And
                .HaveYear(DateTime.Now.Year);
        }

        [Test]
        public void DeveriaGerarDataSaidaEntradaCorretamente()
        {
            _identificao.DataSaidaEntrada.Should()
                .HaveDay(DateTime.Now.Day).And
                .HaveMonth(DateTime.Now.Month).And
                .HaveYear(DateTime.Now.Year);
        }

        [Test]
        public void DeveriaGerarConsumidorFinalCorretamente()
        {
            _identificao.ConsumidorFinal.Should().Be(ConsumidorFinal.Normal);
        }

        [Test]
        public void DeveriaGerarFinalidadeCorretamente()
        {
            _identificao.Finalidade.Should().Be(Finalidade.Normal);
        }

        [Test]
        public void DeveriaGerarModeloCorretamente()
        {
            _identificao.Modelo.Should().Be(ModeloDocumento.NFe);
        }

        [Test]
        public void DeveriaGerarNaturezaOperacaoCorretamente()
        {
            _identificao.NaturezaOperacao.Should().Be(NaturezaOperacao.Venda);
        }

        [Test]
        public void DeveriaGerarPresencaCompradorCorretamente()
        {
            _identificao.PresencaComprador.Should().Be(PresencaComprador.Presencial);
        }

        [Test]
        public void DeveriaGerarSerieCorretamente()
        {
            _identificao.Serie.Should().Be(1);
        }

        [Test]
        public void DeveriaGerarTipoAmbienteCorretamente()
        {
            _identificao.TipoAmbiente.Should().Be(TipoAmbiente.Producao);
        }

        [Test]
        public void DeveriaGerarVersaoAplicativoCorretamente()
        {
            _identificao.VersaoAplicativo.Should().Be("4.0");
        }

        [Test]
        public void DeveriaGerarTipoImpressaoCorretamente()
        {
            _identificao.TipoImpressao.Should().Be(TipoImpressao.DanfeNormalRetrato);
        }

        [Test]
        public void DeveriaGerarTipoEmissaoCorretamente()
        {
            _identificao.TipoEmissao.Should().Be(TipoEmissao.Normal);
        }

        [Test]
        public void DeveriaGerarTipoOperacaoCorretamente()
        {
            _identificao.TipoOperacao.Should().Be(TipoOperacao.Saida);
        }

        [Test]
        public void DeveriaGerarProcessoEmissaoCorretamente()
        {
            _identificao.ProcessoEmissao.Should().Be(ProcessoEmissao.AplicativoContribuinte);
        }

        [Test]
        public void NaoDeveriaGerarCodigoMunicipio()
        {
            _identificao.CodigoMunicipio.Should().Be(0);
        }

        [Test]
        public void NaoDeveriaGerarDataContigencia()
        {
            _identificao.DataContigencia.Should().Be(DateTimeOffset.MinValue);
        }

        [Test]
        public void NaoDeveriaGerarDestinoOperacao()
        {
            _identificao.DestinoOperacao.Should().BeNull();
        }

        [Test]
        public void NaoDeveriaGerarDigitoVerificador()
        {
            _identificao.DigitoVerificador.Should().Be(0);
        }

        [Test]
        public void NaoDeveriaGerarEstado()
        {
            _identificao.Estado.Should().Be(0);
        }

        [Test]
        public void NaoDeveriaGerarIndicadorPagamento()
        {
            _identificao.IndicadorPagamento.Should().BeNull();
        }

        [Test]
        public void NaoDeveriaGerarJustificativa()
        {
            _identificao.Justificativa.Should().BeNull();
        }

        [Test]
        public void NaoDeveriaGerarNumero()
        {
            _identificao.Numero.Should().Be(0);
        }
    }
}
