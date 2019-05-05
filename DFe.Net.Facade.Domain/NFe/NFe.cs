using DFe.Net.Facade.Domain.Enums;

namespace DFe.Net.Facade.Domain.NFe
{
    public class NFe
    {
        public Versao Versao { get; set; }
        public IdentificacaoBase Identificacao { get; set; }
        public Emitente Emitente { get; set; }
        public Destinatario Destinatario { get; set; }
    }
}
