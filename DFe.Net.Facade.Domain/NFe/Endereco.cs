using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Facade.Domain.NFe
{
    public class Endereco
    {
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public long CodigoMunicipio { get; set; }

        public string Municipio { get; set; }

        public string UF { get; set; }

        public string CEP { get; set; }

        public int? Pais { get; set; }

        public string NomePais { get; set; }

        public long? Telefone { get; set; }
    }
}
