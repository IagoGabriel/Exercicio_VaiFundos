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
        private int codMoeda;
        private float rendimento;


        public FundoInvestimento(int increment, String nome, int codMoeda, float rendimento)
        {
            this.codInvestimento = increment;
            this.nome = nome;
            this.codMoeda = codMoeda;
            this.rendimento = rendimento;
        }

        public int getCodInvestimento()
        {
            return codInvestimento;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public int getCodMoeda()
        {
            return codMoeda;
        }


        public void setRendimento(float rendimento)
        {

            this.rendimento = rendimento;
        }

        public float getRendimento() {
            return rendimento;
        }

        public void aplicar(Aplicacao aplicacao){
            this.aplicacao.Add(aplicacao);
        }

        
    }
}
