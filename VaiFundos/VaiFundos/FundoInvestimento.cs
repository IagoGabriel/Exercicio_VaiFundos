using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class FundoInvestimento
    {
        private int codInvestimento;
        private String nome;
        private List<Aplicacao> aplicacao = new List<Aplicacao>();
        private Moeda moeda;

        public FundoInvestimento(int increment, String nome, Moeda moeda)
        {
            this.codInvestimento = increment;
            this.nome = nome;
            this.moeda = moeda;
        }

        public int getCodInvestimento()
        {
            return codInvestimento;
        }

        public Moeda getMoeda()
        {
            return this.moeda;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void aplicar(Aplicacao aplicacao)
        {
            this.aplicacao.Add(aplicacao);
        }

        public int tempoTotalCadastro(Cliente cliente)
        {
            TimeSpan totalCadastro = DateTime.Parse(DateTime.Now.ToShortDateString()) - DateTime.Parse(cliente.getDataCadastro().ToShortDateString());
            return totalCadastro.Days;
        }

        public void Resgate(double valor, Cliente cliente)
        {
            for (int i = 0; i < this.aplicacao.Count(); i++)
            {
                if (valor.Equals(this.aplicacao[i].getValorAplicacao()))
                {
                    if (tempoTotalCadastro(cliente) >= 365)
                    {

                    }
                }
            }

        }

    }
}

