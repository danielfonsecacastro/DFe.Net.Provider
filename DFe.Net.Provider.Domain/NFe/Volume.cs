using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
   public class Volume
    {
        /// <summary>
        ///     X27 - Quantidade de volumes transportados
        /// </summary>
        public int? QuantidadeVolume { get; set; }

        /// <summary>
        ///     X28 - Espécie dos volumes transportados
        /// </summary>
        public string Especie { get; set; }

        /// <summary>
        ///     X29 - Marca dos volumes transportados
        /// </summary>
        public string Marca { get; set; }

        /// <summary>
        ///     X30 - Numeração dos volumes transportados
        /// </summary>
        public string NumeracaoVolume { get; set; }

        /// <summary>
        ///     X31 - Peso Líquido (em kg)
        /// </summary>
        public decimal? PesoLiquido { get; set; }

        /// <summary>
        ///     X32 - Peso Bruto (em kg)
        /// </summary>
        public decimal? PesoBruto { get; set; }

        /// <summary>
        ///     X33 - Grupo Lacres
        ///     <para>Ocorrência: 0-5000</para>
        /// </summary>
        public List<Lacre> Lacres { get; set; }
    }
}
