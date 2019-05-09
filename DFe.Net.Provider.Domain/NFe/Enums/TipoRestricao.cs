using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe.Enums
{
    /// <summary>
    ///     0=Não há; 1=Alienação Fiduciária;
    ///     2=Arrendamento Mercantil; 3=Reserva de Domínio;
    ///     4=Penhor de Veículos; 9=Outras. (v2.0)
    /// </summary>
    public enum TipoRestricao
    {
        [Description("Não há")] Nenhuma = 0,
        [Description("Alienação Fiduciária")] AlienacaoFiduciaria = 1,
        [Description("Arrendamento Mercantil")] ArrendamentoMercantil = 2,
        [Description("Reserva de Domínio")] ReservaDeDominio = 3,
        [Description("Penhor de Veículos")] PenhorDeVeiculos = 4,
        [Description("Outras")] Outras = 9
    }
}
