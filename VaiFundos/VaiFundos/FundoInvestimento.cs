using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VaiFundos
{
    class FundoInvestimento
    {
        private int codInvestimento;
        private String nome;
        private Moeda moeda;

        private List<Aplicacao> aplicacao = new List<Aplicacao>();

        public FundoInvestimento(int increment, String nome, Moeda moeda)
        {
            this.codInvestimento = increment+1;
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

        public List<Aplicacao> buscaAplicacao( )
        {

            return aplicacao;
            /*List<Aplicacao> aplicacaoCod = null;
            //PARAMOS AQUI, NO DIA 09-09-15 ÀS 18:34!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            for (int i = 0; i < this.aplicacao.Count(); i++)
            {
                if (codigoInvestimento.Equals(aplicacao[i].getCodInvestimento()))
                {
                    return aplicacao[i];
                }
            }

            return null;*/
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

        public static FundoInvestimento buscaFundo(List<FundoInvestimento> fundoInvestimento, int codigoInvestimento)
        {
            for(int i = 0; i < fundoInvestimento.Count(); i++)
            {
                if(codigoInvestimento.Equals(fundoInvestimento[i].getCodInvestimento()))
                {
                    return fundoInvestimento[i];
                }
            }

            return null;
        }

        public static void imprimeListaFundos(List<FundoInvestimento> fundoInvestimento)
        {
            for (int i = 0; i < fundoInvestimento.Count(); i++)
            {
                Console.WriteLine("\nCódigo: {0}\nNome: {1}\nMoeda: {2}\n", fundoInvestimento[i].getCodInvestimento(), fundoInvestimento[i].nome, fundoInvestimento[i].getMoeda().getNomeMoeda());
            }
        }

        public static void lerArquivo(List<FundoInvestimento> fundoInvestimento, Moeda dolar, Moeda real)
        {
            try
            {
                if (File.Exists("../../fundos.txt"))
                {
                    Stream arqDados = File.Open("../../fundos.txt", FileMode.Open);
                    StreamReader leitor = new StreamReader(arqDados);
                    String linha = leitor.ReadLine();
                    String[] separador;
                    FundoInvestimento fundoPadrao;

                    while (linha != null)
                    {
                        separador = linha.Split(';');
                        if (separador[2] == "real") { 
                            fundoPadrao = new FundoInvestimento(fundoInvestimento.Count(), separador[1], real);
                        }
                        else
                        {
                            fundoPadrao = new FundoInvestimento(fundoInvestimento.Count(), separador[1], dolar);
                        }
                        linha = leitor.ReadLine();
                        fundoPadrao.aplicacao = null ;
                        fundoInvestimento.Add(fundoPadrao);
                    }


                    leitor.Close();
                    arqDados.Close();
                }
            }
            catch (IOException io)
            {
                Console.WriteLine("\nOcorreu um erro: {0}", io);
            }
        }

        public static void escreveArquivo(List<FundoInvestimento> fundoInvestimento)
        {
            try
            {

                FileStream arqDados = new FileStream("../../fundos.txt", FileMode.Create, FileAccess.Write);
                StreamWriter escritor = new StreamWriter(arqDados, Encoding.UTF8);

                for (int i = 0; i < fundoInvestimento.Count(); i++)
                {
                    escritor.WriteLine(fundoInvestimento[i].codInvestimento + ";" + fundoInvestimento[i].nome + ";" + fundoInvestimento[i].moeda.getNomeMoeda());
                }

                escritor.Close();
                arqDados.Close();
            }
            catch (IOException io)
            {
                Console.WriteLine("\nOcorreu um erro: {0}", io);
            }

        }

    }
}

