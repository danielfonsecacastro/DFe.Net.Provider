using DFe.Net.Provider.Domain.Enums;
using DFe.Net.Provider.Domain.NFe;
using DFe.Net.Provider.Domain.NFe.Fluent;

namespace DFe.Net.Provider.NFe
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

        public IGerarNota Transporte(Transporte transporte)
        {
            _nfe.Transporte = transporte;
            return this;
        }

        public NFeProvider Gerar()
        {
            return _nfe;
        }
    }
}
