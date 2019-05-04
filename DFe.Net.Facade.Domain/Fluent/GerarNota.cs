using DFe.Net.Facade.Domain.Entities;
using DFe.Net.Facade.Domain.Enums;
using System;

namespace DFe.Net.Facade.Domain.Fluent
{
    public class GerarNota : IGerarNota
    {
        private Entities.NFe _nfe;

        public GerarNota()
        {
            _nfe = new Entities.NFe();
        }
        public Entities.NFe Gerar()
        {
            return _nfe;
        }

        public IGerarNota Identificacao(Identificacao identificacao)
        {
            return this;
        }

        public IGerarNota Versao(Versao versao)
        {
            return this;
        }
    }
}
