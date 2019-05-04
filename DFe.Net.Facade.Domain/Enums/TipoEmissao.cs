using System.ComponentModel;

namespace DFe.Net.Facade.Domain.Enums
{
    public enum TipoEmissao
    {
        [Description("Normal")]
        teNormal = 1,

        [Description("Contingência FS-IA")]
        teFSIA = 2,

        [Description("Contingência SCAN")]
        teSCAN = 3,

        [Description("Contingência DPEC")]
        teEPEC = 4,

        [Description("Contingência FS-DA")]
        teFSDA = 5,

        [Description("Contingência SVC-AN")]
        teSVCAN = 6,

        [Description("Contingência SVC-RS")]
        teSVCRS = 7,

        [Description("Contingência off-line")]
        teOffLine = 9
    }
}
