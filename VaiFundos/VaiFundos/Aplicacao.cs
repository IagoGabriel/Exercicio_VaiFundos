using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Aplicacao
    {
        private int codAplicacao;
        private float valorAplicacao;
        private DateTime dataAplicacao;
        private float rendimento;

        public Aplicacao(int increment, float valorAplicacao)
        {
            this.codAplicacao = increment + 1;    
            this.valorAplicacao = valorAplicacao;
            this.dataAplicacao = DateTime.Now;
        }

        public int getCodAplicacao()
        {
            return codAplicacao;
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
