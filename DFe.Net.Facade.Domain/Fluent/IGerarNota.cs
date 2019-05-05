using DFe.Net.Facade.Domain.NFe;
using DFe.Net.Facade.Domain.Enums;
using DFe.Net.Facade.Domain.Factories;

namespace DFe.Net.Facade.Domain.Fluent
{
    public interface IGerarNota
    {
        IGerarNota Versao(Versao versao);
        IGerarNota Identificacao(IdentificacaoBase identificacao);
        IGerarNota Emitente(Emitente emitente);
        IGerarNota Destinatario(Destinatario destinatario);
        NFe.NFe Gerar();
    }
}
