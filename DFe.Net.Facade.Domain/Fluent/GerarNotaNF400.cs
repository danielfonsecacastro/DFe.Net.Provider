using DFe.Net.Facade.Domain.NFe;
using DFe.Net.Facade.Domain.Enums;
using DFe.Net.Facade.Domain.Factories;

namespace DFe.Net.Facade.Domain.Fluent
{
    public class GerarNotaNF400 : IGerarNota
    {
        private NFe.NFe _nfe;

        public GerarNotaNF400()
        {
            _nfe = new NFe.NFe
            {
                Versao = Enums.Versao.Versao400,
            };
        }
        public NFe.NFe Gerar()
        {
            return _nfe;
        }

        public IGerarNota Identificacao(IdentificacaoBase identificacao)
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
