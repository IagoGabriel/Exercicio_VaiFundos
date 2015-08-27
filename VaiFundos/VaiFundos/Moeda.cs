﻿using System;
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
        protected string usado_pais;
        protected string simbolo;


        public Moeda(int notas, int codmoeda, float valormoeda, float inflacao, string usado_pais, string simbolo)
        {

            this.notas = new int[6];
            this.codmoeda = codmoeda;
            this.valormoeda = valormoeda;
            this.inflacao = inflacao;
            this.usado_pais = usado_pais;
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

   
        public string getUsado_pais()
        {
            return usado_pais;
        }

        public void setUsado_pais(string usado_pais)
        {
            this.usado_pais = usado_pais;
        }

        public string getSimbolo()
        {
            return simbolo;
        }

        public void setSimbolo(string simbolo)
        {
            this.simbolo = simbolo;
        }

      
    }
}