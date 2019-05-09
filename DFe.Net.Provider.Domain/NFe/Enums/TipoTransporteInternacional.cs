using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     1=Marítima;
    ///     2=Fluvial;
    ///     3=Lacustre;
    ///     4=Aérea;
    ///     5=Postal
    ///     6=Ferroviária;
    ///     7=Rodoviária;
    ///     8=Conduto / Rede Transmissão;
    ///     9=Meios Próprios;
    ///     10=Entrada / Saída ficta; 11=Courier; 12=Handcarry. (NT 2013/005 v 1.10).
    /// </summary>
    public enum TipoTransporteInternacional
    {
        /// <summary>
        /// 1=Marítima
        /// </summary>
        [Description("Marítima")]
        Maritima = 1,

        /// <summary>
        /// 2=Fluvial
        /// </summary>
        [Description("Fluvial")]
        Fluvial = 2,

        /// <summary>
        /// 3=Lacustre
        /// </summary>
        [Description("Lacustre")]
        Lacustre = 3,

        /// <summary>
        /// 4=Aérea
        /// </summary>
        [Description("Aérea")]
        Aerea = 4,

        /// <summary>
        /// 5=Postal
        /// </summary>
        [Description("Postal")]
        Postal = 5,

        /// <summary>
        /// 6=Ferroviária
        /// </summary>
        [Description("Ferroviária")]
        Ferroviaria = 6,

        /// <summary>
        /// 7=Rodoviária
        /// </summary>
        [Description("Rodoviária")]
        Rodoviaria = 7,

        /// <summary>
        /// 8=Conduto / Rede de Transmissão
        /// </summary>
        [Description("Conduto / Rede de Transmissão")]
        CondutoRedeTransmissão = 8,

        /// <summary>
        /// 9=Meios Próprios
        /// </summary>
        [Description("Meios Próprios")]
        MeiosProprios = 9,

        /// <summary>
        /// 10=Entrada / Saída ficta
        /// </summary>
        [Description("Entrada / Saída ficta")]
        EntradaSaidaficta = 10,

        /// <summary>
        /// 11=Courier
        /// </summary>
        [Description("Courier")]
        Courier = 11,

        /// <summary>
        /// 12=Handcarry (NT 2013/005 v 1.10)
        /// </summary>
        [Description("Handcarry")]
        Handcarry = 12
    }
}
