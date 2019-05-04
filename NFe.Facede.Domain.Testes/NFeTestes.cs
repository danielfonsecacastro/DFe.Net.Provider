using DFe.Net.Facade.Domain.Entities;
using DFe.Net.Facade.Domain.Enums;
using DFe.Net.Facade.Domain.Fluent;
using NUnit.Framework;

namespace DFe.Net.Facade.Domain.Testes
{
    public class NFeTestes
    {
        [Test]
        public void DeveGerarNFeCorretamente()
        {
            var nfe = new GerarNota();

            var resultado = nfe.Versao(Versao.Versao400)
                .Identificacao(new Identificacao { })
                .Gerar();

            Assert.IsNotNull(resultado);
        }
    }
}
