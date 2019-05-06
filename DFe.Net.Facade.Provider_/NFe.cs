using DFe.Net.Facade.Domain.Enums;
using DFe.Net.Facade.Domain.NFe;

namespace DFe.Net.Facade.Provider
{
    public class NFe : NFeProvider
    {
        public override Versao Versao { get; set; }
        public override IdentificacaoBase Identificacao { get; set; }
        public override Emitente Emitente { get; set; }
        public override Destinatario Destinatario { get; set; }

        public override RetornoNFe Emitir()
        {
            throw new System.NotImplementedException();
        }

      
    }
}
