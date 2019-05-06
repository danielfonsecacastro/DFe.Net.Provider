using DFe.Net.Facade.Domain.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

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
