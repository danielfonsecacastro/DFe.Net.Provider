using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public class Rastro
    {
        /// <summary>
        /// I81 - Número do Lote do produto
        /// Versão 4.0
        /// </summary>
        public string NumeroLote { get; set; }

        /// <summary>
        /// I82 - Quantidade de produto no Lote
        /// Versão 4.0
        /// </summary>
        public decimal QuantidadeLote { get; set; }

        /// <summary>
        /// I83 - Data de fabricação/ Produção
        /// Versão 4.0
        /// </summary>
        public DateTime DataFabricacao { get; set; }

        /// <summary>
        /// I84 - Data de validade
        /// Versão 4.0
        /// </summary>
        public DateTime DataValidade { get; set; }

        /// <summary>
        /// I85 - Código de Agregação
        /// Versão 4.0
        /// </summary>
        public string CodigoAgregacao { get; set; }
    }
}
