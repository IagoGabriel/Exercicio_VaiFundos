using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Resgate
    {
        private FundoInvestimento fundoInvestimento;
        private Aplicacao aplicacao;
        private DateTime dataResgate;

        public Resgate(FundoInvestimento fundoInvestimento, Aplicacao aplicacao)
        {
            this.fundoInvestimento = fundoInvestimento;
            this.aplicacao = aplicacao;
            this.dataResgate = DateTime.Now;
        }

    }
}
