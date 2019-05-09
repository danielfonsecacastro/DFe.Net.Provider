using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public class Adicao
    {
        /// <summary>
        ///     I26 - Numero da Adição
        /// </summary>
        public int NumeroAdicao { get; set; }

        /// <summary>
        ///     I27 - Numero sequencial do item dentro da Adição
        /// </summary>
        public int NumeroSequencial { get; set; }

        /// <summary>
        ///     I28 - Código do fabricante estrangeiro
        /// </summary>
        public string CodigoFabricanteEstrangeiro { get; set; }

        /// <summary>
        ///     I29 - Valor do desconto do item da DI – Adição
        /// </summary>
        public decimal? ValorDesconto { get; set; }
        
        /// <summary>
        ///     I29a - Número do ato concessório de Drawback
        /// </summary>
        public string NumeroDrawback { get; set; }
    }
}
