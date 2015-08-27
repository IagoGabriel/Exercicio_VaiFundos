using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Moeda
    {

        protected int[] notas = new int [6] { 2, 5, 10, 20, 50, 100 };
        protected int codmoeda;
        protected float valormoeda;
        protected float inflacao;
        protected string usando_pais;
        protected string simbolo;


        public Moeda(int notas, int codmoeda, float valormoeda, float inflacao, string usando_pais, string simbolo)
        {

            this.notas = new int[6];
            this.codmoeda = codmoeda;
            this.valormoeda = valormoeda;
            this.inflacao = inflacao;
            this.usando_pais = usando_pais;
            this.simbolo = simbolo;

        }

       

        public void setCodmoeda(int codmoeda)
        {
            this.codmoeda = codmoeda;
        }

        public int getCodmoeda()
        {
            return codmoeda;
        }

        public void setValormoeda(float valormoeda)
        {
            this.valormoeda = valormoeda;
        }

        public float getInflacao()
        {
            return inflacao;
        }

        public void setInflacao(float inflacao)
        {
            this.inflacao = inflacao;
        }

        public string getUsando_pais()
        {
            return usando_pais;
        }

        public void setSimbolo(string simbolo)
        {
            this.simbolo = simbolo;
        }

      
    }
}
