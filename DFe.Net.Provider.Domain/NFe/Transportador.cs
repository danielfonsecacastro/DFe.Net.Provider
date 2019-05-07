using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public class Transportador
    {
        /// <summary>
        ///     X04 - CNPJ do Transportador
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        ///     X05 - CPF do Transportador
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        ///     X06 - Razão Social ou nome
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        ///     X07 - Inscrição Estadual do Transportador
        /// </summary>
        public string IE { get; set; }

        /// <summary>
        ///     X08 - Endereço Completo
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        ///     X09 - Nome do município
        /// </summary>
        public string NomeMunicipio { get; set; }

        /// <summary>
        ///     X10 - Sigla da UF
        /// </summary>
        public string UF { get; set; }
    }
}
