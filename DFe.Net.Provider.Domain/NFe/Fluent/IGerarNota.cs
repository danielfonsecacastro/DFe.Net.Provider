using DFe.Net.Provider.Domain.Enums;

namespace DFe.Net.Provider.Domain.NFe.Fluent
{
    public interface IGerarNota
    {
        IGerarNota Versao(Versao versao);
        IGerarNota Identificacao(IdentificacaoBase identificacao);
        IGerarNota Emitente(Emitente emitente);
        IGerarNota Destinatario(Destinatario destinatario);
        IGerarNota Transporte(Transporte transporte);
        NFeProvider Gerar();
    }
}
