using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public abstract class ICMSBase
    {
        public override string ToString()
        {
            return IdentificacaoICMS();
        }

        public abstract string IdentificacaoICMS();
    }
}
