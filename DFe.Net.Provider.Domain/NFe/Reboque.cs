using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
   public  class Reboque
    {
        /// <summary>
        ///     X23 - Placa do Veículo
        /// </summary>
        public string Placa { get; set; }

        /// <summary>
        ///     X24 - Sigla da UF
        /// </summary>
        public string UF { get; set; }

        /// <summary>
        ///     X25 - Registro Nacional de Transportador de Carga (ANTT)
        /// </summary>
        public string RNTC { get; set; }
    }
}
