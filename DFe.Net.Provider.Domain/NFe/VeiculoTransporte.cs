using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public class VeiculoTransporte
    {
        /// <summary>
        ///     X19 - Placa do Veículo
        /// </summary>
        public string Placa { get; set; }

        /// <summary>
        ///     X20 - Sigla da UF
        /// </summary>
        public string UF { get; set; }

        /// <summary>
        ///     X21 - Registro Nacional de Transportador de Carga (ANTT)
        /// </summary>
        public string RNTC { get; set; }
    }
}
