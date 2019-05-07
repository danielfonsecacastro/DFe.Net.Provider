using DFe.Net.Provider.Domain.Enums;
using DFe.Net.Provider.Domain.NFe;
using DFe.Net.Provider.Domain.NFe.Fluent;
using DFe.Net.Provider.NFe;
using FluentAssertions;
using System;
using Xunit;

namespace NotaNF400Testes
{
    public class GerarNotaNF400Testes
    {
        private IGerarNota _gerarNota;

        public GerarNotaNF400Testes()
        {
            _gerarNota = new GerarNotaNF400();
        }

        [Fact]
        public void DeveGerarComUltimaVersaoQuandoNaoInformado()
        {
            var resultado = _gerarNota
                .Identificacao(new Identificacao { })
                .Gerar();

            resultado.Versao.Should().Be(Versao.Versao400);
        }

        [Theory]
        [InlineData(Versao.Versao100)]
        [InlineData(Versao.Versao200)]
        [InlineData(Versao.Versao300)]
        [InlineData(Versao.Versao310)]
        public void DeveGerarComVersao4MesmoQuandoInformadoVersao(Versao versao)
        {
            var resultado = _gerarNota.Versao(versao)
                .Identificacao(new Identificacao { })
                .Gerar();

            resultado.Versao.Should().Be(Versao.Versao400);
        }

        [Fact]
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

            var resultado = _gerarNota
                .Identificacao(identificacao)
                .Gerar();

            resultado.Identificacao.Should().Be(identificacao);
        }

        [Fact]
        public void DeveriaGerarEmitenteCorretamente()
        {
            var emitente = new Emitente(new Endereco { }) { };

            var resultado = _gerarNota
                .Emitente(emitente)
                .Gerar();

            resultado.Emitente.Should().Be(emitente);
        }

        [Fact]
        public void DeveriaGerarDestinatarioCorretamente()
        {
            var destinatario = new Destinatario(new Endereco { }) { };

            var resultado = _gerarNota
                .Destinatario(destinatario)
                .Gerar();

            resultado.Destinatario.Should().Be(destinatario);
        }

        [Fact]
        public void DeveriaGerarTransporteCorretamente()
        {
            var transporte = new Transporte { Transportador = new Transportador(), VeiculoTransporte = new VeiculoTransporte() };

            var resultado = _gerarNota
                .Transporte(transporte)
                .Gerar();

            resultado.Transporte.Should().Be(transporte);
        }

        [Fact]
        public void DeveriaGerarFaturaCorretamente()
        {
            var cobranca = new Cobranca { };

            var resultado = _gerarNota
                .Cobranca(cobranca)
                .Gerar();

            resultado.Cobranca.Should().Be(cobranca);
        }
    }
   
}
