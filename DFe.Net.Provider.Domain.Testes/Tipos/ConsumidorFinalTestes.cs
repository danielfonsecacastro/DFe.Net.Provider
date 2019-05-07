using DFe.Net.Provider.Domain.Enums;
using NUnit.Framework;
using System;

namespace DFe.Net.Facade.Domain.Testes.Tipos
{
    public class ConsumidorFinalTestes
    {
        [Test]
        public void DeveriaConterAMesmaQuantidadeDeitens()
        {
            var resultado = Enum.GetNames(typeof(ConsumidorFinal)).Length;
           
        }
    }
}
