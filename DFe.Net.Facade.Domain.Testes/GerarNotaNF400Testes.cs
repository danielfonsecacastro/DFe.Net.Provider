using DFe.Net.Facade.Domain.NFe;
using DFe.Net.Facade.Domain.Enums;
using DFe.Net.Facade.Domain.Fluent;
using FluentAssertions;
using NUnit.Framework;
using System;
using DFe.Net.Facade.Domain.Factories;

namespace NotaNF400Testes
{
    public class GerarNotaNF400Testes
    {

    }
    public class GerarNotaNF400TestesVersao
    {
        private IGerarNota _gerarNota;

        [SetUp]
        public void Setup()
        {
            _gerarNota = new GerarNotaNF400();
        }

        [Test]
        public void DeveGerarComUltimaVersaoQuandoNaoInformado()
        {
            var resultado = _gerarNota
                .Identificacao(new Identificacao { })
                .Gerar();

            resultado.Versao.Should().Be(Versao.Versao400);
        }

        [Test]
        [TestCase(Versao.Versao100)]
        [TestCase(Versao.Versao200)]
        [TestCase(Versao.Versao300)]
        [TestCase(Versao.Versao310)]
        public void DeveGerarComVersao4MesmoQuandoInformadoVersao(Versao versao)
        {
            var resultado = _gerarNota.Versao(versao)
                .Identificacao(new Identificacao { })
                .Gerar();

            resultado.Versao.Should().Be(Versao.Versao400);
        }
    }

    public class GerarNotaTestesIdentificacao
    {
        private IGerarNota _nota400;

        [SetUp]
        public void Setup()
        {
            _nota400 = new GerarNotaNF400();
        }

        [Test]
        public void DeveGerarIdentificacaoCorretamente()
        {
            var identificacao = new Identificacao
            {
                ChaveAcesso = new ChaveAcesso(),
                CodigoMunicipio = 2000,
                ConsumidorFinal = ConsumidorFinal.Normal,
                DataEmissao = DateTime.Now,
                DataSaidaEntrada = DateTime.Now,
                DestinoOperacao = DestinoOperacao.Interestadual,
                DigitoVerificador = 5,
                Estado = Estado.SP,
                Finalidade = Finalidade.Normal,
                IndicadorPagamento = IndicadorPagamento.Vista,
                Modelo = ModeloDocumento.NFe,
                NaturezaOperacao = NaturezaOperacao.Venda,
                Numero = 1,
                PresencaComprador = PresencaComprador.Presencial,
                ProcessoEmissao = ProcessoEmissao.AplicativoContribuinte,
                Serie = 1,
                TipoOperacao = TipoOperacao.Saida,
                TipoAmbiente = TipoAmbiente.Homologacao,
                TipoEmissao = TipoEmissao.Normal,
                TipoImpressao = TipoImpressao.DanfeNFCe,
                VersaoAplicativo = "1"
            };

            var resultado = _nota400
                .Identificacao(identificacao)
                .Gerar();

            resultado.Identificacao.Should().Be(identificacao);
        }

        [Test]
        public void DeveGerarEmitenteCorretamente()
        {
            var emitente = new Emitente(new Endereco { }) { };

            var resultado = _nota400
                .Emitente(emitente)
                .Gerar();

            resultado.Emitente.Should().Be(emitente);
        }

        [Test]
        public void DeveGerarDestinatarioCorretamente()
        {
            var destinatario = new Destinatario(new Endereco { }) { };

            var resultado = _nota400
                .Destinatario(destinatario)
                .Gerar();

            resultado.Destinatario.Should().Be(destinatario);
        }
    }
}
