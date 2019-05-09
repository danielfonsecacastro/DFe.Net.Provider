namespace DFe.Net.Provider.Domain.NFe
{
    public abstract class ProdutoEspecifico
    {
        public override string ToString()
        {
            return NomeProdutoEspecifico();
        }

        public abstract string NomeProdutoEspecifico();
    }
}
