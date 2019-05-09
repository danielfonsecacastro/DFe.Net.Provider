using DFe.Net.Provider.Domain.NFe.Enums;

namespace DFe.Net.Provider.Domain.NFe
{
    public class ProdutoEspecificoVeiculo : ProdutoEspecifico
    {
        private decimal _pesoL;
        private decimal _pesoB;
        private decimal _cmt;

        /// <summary>
        ///     J02 - Tipo da operação
        /// </summary>
        public TipoOperacaoProdutoVeiculo TipoOperacao { get; set; }

        /// <summary>
        ///     J03 - Chassi do veículo
        /// </summary>
        public string Chassi { get; set; }

        /// <summary>
        ///     J04 - Cor(Código de cada montadora)
        /// </summary>
        public string Cor { get; set; }

        /// <summary>
        ///     J05 - Descrição da Cor
        /// </summary>
        public string DescricaoCor { get; set; }

        /// <summary>
        ///     J06 - Potência Motor (CV)
        /// </summary>
        public string PotenciaMotor { get; set; }

        /// <summary>
        ///     J07 - Cilindradas
        /// </summary>
        public string Cilindradas { get; set; }

        /// <summary>
        ///     J08 - Peso Líquido
        /// </summary>
        public decimal PesoLiquido { get; set; }

        /// <summary>
        ///     J09 - Peso Bruto
        /// </summary>
        public decimal PesoBruto { get; set; }

        /// <summary>
        ///     J10 - Serial (série)
        /// </summary>
        public string Serie { get; set; }

        /// <summary>
        ///     J11 - Tipo de combustível. Utilizar Tabela RENAVAM (v2.0)
        /// </summary>
        public string TipoCombustive { get; set; }

        /// <summary>
        ///     J12 - Número de Motor
        /// </summary>
        public string NumeroMotor { get; set; }

        /// <summary>
        ///     J13 - Capacidade Máxima de Tração
        /// </summary>
        public decimal CMT { get; set; }

        /// <summary>
        ///     J14 - Distância entre eixos
        /// </summary>
        public string DistranciaEntreEixos { get; set; }

        /// <summary>
        ///     J16 - Ano Modelo de Fabricação
        /// </summary>
        public int AnoModeloFabricacao { get; set; }

        /// <summary>
        ///     J17 - Ano de Fabricação
        /// </summary>
        public int AnoFabricacao { get; set; }

        /// <summary>
        ///     J18 - Tipo de Pintura
        /// </summary>
        public string TipoPintura { get; set; }

        /// <summary>
        ///     J19 - Tipo de Veículo
        /// </summary>
        public string TipoVeiculo { get; set; }

        /// <summary>
        ///     J20 - Espécie de Veículo
        /// </summary>
        public int EspecieVeiculo { get; set; }

        /// <summary>
        ///     J21 - Condição do VIN
        /// </summary>
        public CondicaoVin VIN { get; set; }

        /// <summary>
        ///     J22 - Condição do Veículo
        /// </summary>
        public CondicaoVeiculo condVeic { get; set; }

        /// <summary>
        ///     J23 - Código Marca Modelo
        /// </summary>
        public string CodigoMarcaModelo { get; set; }

        /// <summary>
        ///     J24 - Código da Cor
        /// </summary>
        public string CodigoCorDENATRAN { get; set; }

        /// <summary>
        ///     J25 - Capacidade máxima de lotação
        /// </summary>
        public int CapacidadeMaxima { get; set; }

        /// <summary>
        ///     J26 - Restrição
        /// </summary>
        public TipoRestricao TipoRestricao { get; set; }

        public override string NomeProdutoEspecifico()
        {
            return "Veículo";
        }
    }
}
