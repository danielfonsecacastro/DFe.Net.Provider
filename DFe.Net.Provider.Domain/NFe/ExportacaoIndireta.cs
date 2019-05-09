using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public class ExportacaoIndireta
    {
        /// <summary>
        ///     I53 - Número do Registro de Exportação
        /// </summary>
        public string NumeroRegistroExportacao { get; set; }

        /// <summary>
        ///     I54 - Chave de Acesso da NF-e recebida para exportação
        /// </summary>
        public string ChaveNFeRecebida { get; set; }

        /// <summary>
        ///     I55 - Quantidade do item realmente exportado
        /// </summary>
        public decimal QuantidadeExportado { get; set; }
    }
}
