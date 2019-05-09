using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public class Detalhe
    {
        /// <summary>
        ///     H02 - Número do item do NF
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        ///     I01 - Detalhamento de Produtos e Serviços
        /// </summary>
        public Produto Produto { get; set; }

        ///// <summary>
        /////     M01 - Tributos incidentes no Produto ou Serviço
        ///// </summary>
        //public imposto imposto { get; set; }

        ///// <summary>
        /////     UA01 - Informação do Imposto devolvido
        ///// </summary>
        //public impostoDevol impostoDevol { get; set; }

        /// <summary>
        ///     V01 - Informações Adicionais do Produto
        /// </summary>
        public string InformacoesAdicionais { get; set; }
    }
}
