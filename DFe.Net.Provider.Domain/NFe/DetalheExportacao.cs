using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
   public class DetalheExportacao
    {
        /// <summary>
        ///     I51 - Número do ato concessório de Drawback
        /// </summary>
        public string NumeroDrawback { get; set; }

        /// <summary>
        ///     I52 - Grupo sobre exportação indireta
        /// </summary>
        public ExportacaoIndireta ExportacaoIndireta { get; set; }
    }
}
