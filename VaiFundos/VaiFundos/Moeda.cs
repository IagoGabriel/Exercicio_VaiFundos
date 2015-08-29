using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Moeda
    {
        private int codMoeda;
        protected List<int> notas = new List<int>();
        protected float valorMoeda;
        protected float inflacao;
        protected String usadoPais;
        protected String simbolo;

        public Moeda(int increment, float valorMoeda, float inflacao, String usadoPais, String simbolo)
        {
            this.codMoeda = increment + 1;
            this.valorMoeda = valorMoeda;
            this.inflacao = inflacao;
            this.usadoPais = usadoPais;
            this.simbolo = simbolo;
        }

        public int getCodMoeda()
        {
            return codMoeda;
        }

        public float getValorMoeda()
        {
            return valorMoeda;
        }

        public void setValorMoeda(float valorMoeda)
        {
            this.valorMoeda = valorMoeda;
        }

        public float getInflacao()
        {
            return inflacao;
        }

        public void setInflacao(float inflacao)
        {
            this.inflacao = inflacao;
        }

        public String getUsadoPais()
        {
            return usadoPais;
        }

        public void setUsadoPais(String usadoPais)
        {
            this.usadoPais = usadoPais;
        }

        public String getSimbolo()
        {
            return simbolo;
        }

        public void setSimbolo(String simbolo)
        {
            this.simbolo = simbolo;
        }
    }
}

