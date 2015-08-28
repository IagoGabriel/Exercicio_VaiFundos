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
        private int codCliente;
        private int codFundo;
        private float valorAplicacao; //Falta fazer getValorAplicacao (não fazer setValorAplicacao !)
        private DateTime dataAplicacao; //Falta fazer getDataAplicacao (não fazer setDataAplicacao !)

        public Aplicacao(int increment, int codCliente, int codFundo, float valorAplicacao)
        {
            this.codAplicacao = increment+1;
            this.codCliente = codCliente;
            this.codFundo = codFundo;
            this.valorAplicacao = valorAplicacao;
            this.dataAplicacao = DateTime.Now;
        }

        public int getCodAplicacao()
        {
            return codAplicacao;
        }

        public int getCodCliente()
        {
            return codCliente;
        }

        public int getCodFundo()
        {
            return codFundo;
        }

    }
}
