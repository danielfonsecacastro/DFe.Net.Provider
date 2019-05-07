using DFe.Net.Provider.Domain.Enums;
using System;
using Xunit;

namespace DFe.Net.Facade.Domain.Testes.Tipos
{
    public class ConsumidorFinalTestes
    {
        [Fact]
        public void DeveriaConterAMesmaQuantidadeDeitens()
        {
            var resultado = Enum.GetNames(typeof(ConsumidorFinal)).Length;
           
        }
    }
}
