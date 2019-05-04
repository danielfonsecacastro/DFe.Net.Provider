using DFe.Net.Facade.Domain.Entities;
using DFe.Net.Facade.Domain.Enums;

namespace DFe.Net.Facade.Domain.Fluent
{
    public interface IGerarNota
    {
        IGerarNota Versao(Versao versao);
        IGerarNota Identificacao(Identificacao identificacao);

        Entities.NFe Gerar();
    }
}
