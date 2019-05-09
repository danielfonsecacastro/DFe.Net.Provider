using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    /// Indicador de Escala Relevante:
    /// S -  Produzido em Escala Relevante; N – Produzido em Escala NÃO Relevante.
    /// Versão 4.00
    /// </summary>
    public enum IndicadorEscala
    {
        [Description("Produzido em Escala Relevante")] S = 'S',
        [Description("Produzido em Escala NÃO Relevante")] N = 'N'
    }
}
