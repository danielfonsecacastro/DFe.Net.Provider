using System;

namespace DFe.Net.Provider.Domain.NFe
{
    public class ProdutoEspecificoMedicamento : ProdutoEspecifico
    {
        /// <summary>
        /// K01a - Código de Produto da ANVISA
        /// VERSÃO 4.00
        /// </summary>
        public string CodigoANVISA { get; set; }

        public string MotivoIsencao { get; set; }

        /// <summary>
        ///     K02 - Número do Lote de medicamentos ou de matérias-primas farmacêuticas
        /// VERSÃO 3.00
        /// </summary>
        public string NumeroLote { get; set; }

        /// <summary>
        ///     K03 - Quantidade de produto no Lote de medicamentos ou de matérias-primas farmacêuticas
        /// Versão 3.00
        /// </summary>
        public decimal? QuantidadeLote { get; set; }

        /// <summary>
        ///     K04 - Data de fabricação.
        /// Versão 3.00
        /// </summary>
        public DateTime? DataFabricacao { get; set; }


        /// <summary>
        ///     K05 - Data de validade.
        /// Versão 3.00
        /// </summary>
        public DateTime? DataValidade { get; set; }

        /// <summary>
        ///     K06 - Preço máximo consumidor
        /// Versão 3.00
        /// Versão 4.00
        /// </summary>
        public decimal ValorMaximoConsumidor { get; set; }

        public override string NomeProdutoEspecifico()
        {
            return "Medicamento";
        }
    }
}
