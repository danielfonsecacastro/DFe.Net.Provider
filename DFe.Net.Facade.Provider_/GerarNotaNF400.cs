using DFe.Net.Facade.Domain.Enums;
using DFe.Net.Facade.Domain.Fluent;
using DFe.Net.Facade.Domain.NFe;

namespace DFe.Net.Facade.Provider
{
    public class GerarNotaNF400 : IGerarNota
    {
        private NFeProvider _nfe;

        public GerarNotaNF400()
        {
            _nfe = new NFe
            {
                Versao = Domain.Enums.Versao.Versao400,
            };
        }

        public IGerarNota Emitente(Emitente emitente)
        {
            _nfe.Emitente = emitente;
            return this;
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

        public IGerarNota Destinatario(Destinatario destinatario)
        {
            _nfe.Destinatario = destinatario;
            return this;
        }

        public NFeProvider Gerar()
        {
            return _nfe;
        }
    }
}
