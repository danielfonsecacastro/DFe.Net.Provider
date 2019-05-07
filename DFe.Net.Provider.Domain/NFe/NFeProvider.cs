using DFe.Net.Provider.Domain.Enums;

namespace DFe.Net.Provider.Domain.NFe
{
    public abstract class NFeProvider
    {
        public abstract Versao Versao { get; set; }
        public abstract IdentificacaoBase Identificacao { get; set; }
        public abstract Emitente Emitente { get; set; }
        public abstract Destinatario Destinatario { get; set; }
        public abstract RetornoNFe Emitir();
    }
}
