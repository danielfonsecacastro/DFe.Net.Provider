using DFe.Net.Provider.Domain.NFe;
using System;

namespace DFe.Net.Provider.Domain.Factories
{
    public static class IdentificacaoFactory
    {
        public static IdentificacaoBase Gerar(TipoIdentificacao tipo)
        {
            switch (tipo)
            {
                case TipoIdentificacao.Padrao400:
                    return new IdentificacaoPadrao400();
                default:
                    throw new NotImplementedException();
            }
        }

     
    }

    public enum TipoIdentificacao
    {
        Padrao400
    }
}
