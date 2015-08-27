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


        public FundoInvestimento(int increment, String nome, int codMoeda)
        {
            this.codInvestimento = increment;
            this.nome = nome;
            this.codMoeda = codMoeda;
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

        public void aplicar(Aplicacao aplicacao){
            this.aplicacao.Add(aplicacao);
        }

        
    }
}
