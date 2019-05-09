using DFe.Net.Provider.Domain.NFe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public class ProdutoEspecificoArma : ProdutoEspecifico
    {
        /// <summary>
        ///     L02 - Indicador do tipo de arma de fogo
        /// </summary>
        public TipoArma tpArma { get; set; }

        /// <summary>
        ///     L03 - Número de série da arma
        /// </summary>
        public string NumeroSerie { get; set; }

        /// <summary>
        ///     L04 - Número de série do cano
        /// </summary>
        public string NumeroCano { get; set; }

        /// <summary>
        ///     L05 - Descrição completa da arma, compreendendo: calibre, marca, capacidade, tipo de funcionamento, comprimento e
        ///     demais elementos que permitam a sua perfeita identificação.
        /// </summary>
        public string Descricao { get; set; }

        public override string NomeProdutoEspecifico()
        {
            return "Arma";
        }
    }
}
