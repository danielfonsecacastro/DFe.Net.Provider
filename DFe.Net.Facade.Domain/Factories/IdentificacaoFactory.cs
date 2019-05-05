using DFe.Net.Facade.Domain.NFe;

namespace DFe.Net.Facade.Domain.Factories
{
    public static class IdentificacaoFactory
    {
        public static IdentificacaoBase Gerar(TipoIdentificacao tipo)
        {
            switch (tipo)
            {
                case TipoIdentificacao.Padrao400:
                default:
                    return new IdentificacaoPadrao400();
            }
        }
    }

    public enum TipoIdentificacao
    {
        Padrao400
    }
}
