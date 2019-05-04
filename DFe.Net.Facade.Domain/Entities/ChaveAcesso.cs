using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Facade.Domain.Entities
{
    public class ChaveAcesso
    {
        public int Codigo { get; set; }

        public int GerarAleatorio()
        {
            Codigo = (new Random()).Next(0, 999999);
            return Codigo;
        }
    }
}
