using DFe.Net.Facade.Domain.Entities;
using DFe.Net.Facade.Domain.Enums;

namespace DFe.Net.Facade.Domain.Fluent
{
    public class GerarNotaNF400 : IGerarNota
    {
        private Entities.NFe _nfe;

        public GerarNotaNF400()
        {
            _nfe = new Entities.NFe
            {
                Versao = Enums.Versao.Versao400,
            };
        }
        public Entities.NFe Gerar()
        {
            return _nfe;
        }

        public IGerarNota Identificacao(Identificacao identificacao)
        {
            _nfe.Identificacao = identificacao;
            return this;
        }

        public IGerarNota Versao(Versao versao)
        {
            return this;
        }
    }
}
