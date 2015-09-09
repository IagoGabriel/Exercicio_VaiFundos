using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Aplicacao
    {
        private float valorAplicacao;
        private DateTime dataAplicacao;
        private float rendimento;

        public Aplicacao(float valorAplicacao)
        {    
            this.valorAplicacao = valorAplicacao;
            this.dataAplicacao = DateTime.Now;
            this.rendimento = 0;
        }

        public float getValorAplicacao()
        {
            return valorAplicacao;
        }

        public DateTime getDataAplicacao()
        {
            return dataAplicacao;
        }

        public float getRendimento()
        {
            return rendimento;
        }
    }
}
