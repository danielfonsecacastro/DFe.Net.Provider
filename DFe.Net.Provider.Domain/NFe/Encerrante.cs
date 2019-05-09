namespace DFe.Net.Provider.Domain.NFe
{
    public class Encerrante
    {
        /// <summary>
        /// LA12 - Número de identificação do bico utilizado no abastecimento
        /// </summary>
        public int NumeroBico { get; set; }

        /// <summary>
        /// LA13 - Número de identificação da bomba ao qual o bico está interligado
        /// </summary>
        public int? NumeroBomba { get; set; }

        /// <summary>
        /// LA14 - Número de identificação do tanque ao qual o bico está interligado
        /// </summary>
        public int NumeroTanque { get; set; }

        /// <summary>
        /// LA15 - Valor do Encerrante no início do abastecimento
        /// </summary>
        public decimal ValorEncerranteInicio { get; set; }

        /// <summary>
        /// LA16 - Valor do Encerrante no final do abastecimento
        /// </summary>
        public decimal ValorEncerranteFinal { get; set; }
    }
}
