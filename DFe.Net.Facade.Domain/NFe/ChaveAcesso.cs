using System;

namespace DFe.Net.Facade.Domain.NFe
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
