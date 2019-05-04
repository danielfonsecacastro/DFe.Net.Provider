using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Facade.Domain.Enums
{
    public enum ModeloDocumento
    {
        [Description("NF-e")]
        NFe = 55,

        [Description("MDFe")]
        MDFe = 58,

        [Description("NFCe")]
        NFCe = 65,

        [Description("CTe")]
        CTe = 57,

        [Description("CTeOS")]
        CTeOS = 67
    }
}
