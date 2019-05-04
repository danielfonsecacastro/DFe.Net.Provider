using DFe.Net.Facade.Domain.Entities;
using DFe.Net.Facade.Domain.Enums;
using DFe.Net.Facade.Domain.Fluent;
using FluentAssertions;
using NUnit.Framework;

namespace DFe.Net.Facade.Domain.Testes
{
    public class GerarNotaTestes
    {

    }
    public class GerarNotaTestesVersao
    {
        private IGerarNota _gerarNota;

        [SetUp]
        public void Setup()
        {
            _gerarNota = new GerarNota();
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
        [TestCase(Versao.Versao400)]
        public void DeveGerarComVersaoCorretamente(Versao versao)
        {


            var resultado = _gerarNota.Versao(versao)
                .Identificacao(new Identificacao { })
                .Gerar();

            resultado.Versao.Should().Be(versao);
        }
    }
}
