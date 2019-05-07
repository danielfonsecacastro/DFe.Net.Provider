using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.Enums
{
    public enum TipoImpressao
    {
        [Description("Sem geração de DANFE")]
        SemGeracaoDanfe = 0,

        [Description("DANFE normal, Retrato")]
        DanfeNormalRetrato = 1,

        [Description("DANFE normal, Paisagem")]
        DanfeNormalPaisagem = 2,

        [Description("DANFE Simplificado")]
        DanfeSimplificado = 3,

        [Description("DANFE NFC-e")]
        DanfeNFCe = 4,

        [Description("DANFE NFC-e em mensagem eletrônica")]
        DanfeNFCeMensagemEletronica = 5
    }
}
