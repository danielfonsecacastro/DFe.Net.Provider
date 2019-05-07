using DFe.Net.Provider.Domain.NFe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public class Transporte
    {
        /// <summary>
        ///     X02 - Modalidade do frete
        /// Versão 3.10
        /// Versão 4.00
        /// </summary>
        public ModalidadeFrete? ModalidadeFrete { get; set; }

        /// <summary>
        ///     X03 - Grupo Transportador
        /// </summary>
        public Transportador Transportador { get; set; }

        /// <summary>
        ///     X11 - Grupo Retenção ICMS transporte
        /// </summary>
        public RetencaoICMSTransporte RetencaoICMSTransporte { get; set; }

        /// <summary>
        ///     X18 - Grupo Veículo Transporte
        /// </summary>
        public VeiculoTransporte VeiculoTransporte { get; set; }

        /// <summary>
        ///     X22 - Grupo Reboque
        ///     <para>Ocorrência: 0-5</para>
        /// </summary>
        public List<Reboque> Reboque { get; set; }

        /// <summary>
        ///     X26 - Grupo Volumes
        ///     <para>Ocorrência: 0-5000</para>
        /// </summary>
        public List<Volume> Volume { get; set; }

        /// <summary>
        ///     X25a - Identificação do vagão
        /// </summary>
        public string Vagao { get; set; }

        /// <summary>
        ///     X25b - Identificação da balsa
        /// </summary>
        public string Balsa { get; set; }
    }
}
