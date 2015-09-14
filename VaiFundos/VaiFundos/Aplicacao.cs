using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VaiFundos
{
    class Aplicacao
    {
        private float valorAplicacao;
        private int codInvestimento;
        private DateTime dataAplicacao;
        private float rendimento;
        private int codCliente;

        public Aplicacao(float valorAplicacao, int codInvestimento, DateTime dataAplicacao, float rendimento, int codCliente)
        {
            this.valorAplicacao = valorAplicacao;
            this.codInvestimento = codInvestimento;
            this.dataAplicacao = dataAplicacao;
            this.rendimento = rendimento;
            this.codCliente = codCliente;
        }

        public void setCodInvestimento(int codInvestimento)
        {
            this.codInvestimento = codInvestimento;
        }

        public float getCodInvestimento()
        {
            return codInvestimento;
        }

        public float getValorAplicacao()
        {
            return valorAplicacao;
        }

        public void setDataAplicacao(DateTime dataAplicacao)
        {
            this.dataAplicacao = dataAplicacao;
        }

        public DateTime getDataAplicacao()
        {
            return dataAplicacao;
        }

        public void setRendimento(float rendimento)
        {
            this.rendimento = rendimento;
        }

        public float getRendimento()
        {
            return rendimento;
        }

        public int getCodCliente()
        {
            return codCliente;
        }

        public static void escreveArquivo(Aplicacao aplicacao)
        {
            try
            {
                FileStream arqDados = new FileStream("../../aplicacao.txt", FileMode.Append, FileAccess.Write);
                StreamWriter escritor = new StreamWriter(arqDados, Encoding.UTF8);

                escritor.WriteLine(aplicacao.valorAplicacao + ";" + aplicacao.codInvestimento + ";" + aplicacao.dataAplicacao.ToShortDateString() + ";" + aplicacao.rendimento + ";" + aplicacao.codCliente);

                escritor.Close();
                arqDados.Close();
            }
            catch (IOException io)
            {
                Console.WriteLine("\nOcorreu um erro: {0}", io);
            }

        }

        public static void lerArquivo(List<Aplicacao> aplicacao)
        {
            try
            {
                if (File.Exists("../../aplicacao.txt"))
                {
                    Stream arqDados = File.Open("../../aplicacao.txt", FileMode.Open);
                    StreamReader leitor = new StreamReader(arqDados);
                    String linha = leitor.ReadLine();
                    String[] separador;
                    Aplicacao aplicacaoPadrao;

                    while (linha != null)
                    {
                        separador = linha.Split(';');

                        aplicacaoPadrao = new Aplicacao(float.Parse(separador[0]), int.Parse(separador[1]), DateTime.Parse(separador[2]), float.Parse(separador[3]), int.Parse(separador[4]));

                        linha = leitor.ReadLine();
                        aplicacao.Add(aplicacaoPadrao);
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

        public static void imprimeListaAplicacao(List<Aplicacao> aplicacao)
        {
            for (int i = 0; i < aplicacao.Count(); i++)
            {
                Console.WriteLine("\nValor Aplicação: {0}\nCódigo Investimento: {1}\nData Aplicaçao: {2}\nRendimento: {3}\n", aplicacao[i].valorAplicacao, aplicacao[i].codInvestimento, aplicacao[i].dataAplicacao, aplicacao[i].rendimento);
            }
        }

        public static List<Aplicacao> buscaAplicacao(List<Aplicacao> aplicacao, int codInvestimento)
        {
            List<Aplicacao> aplicacaoCod = null;

            for (int i = 0; i < aplicacao.Count(); i++)
            {
                if (codInvestimento.Equals(aplicacao[i].getCodInvestimento()))
                {
                    aplicacaoCod.Add(aplicacao[i]);
                }
            }
            return aplicacaoCod;
        }

        public static List<Aplicacao> buscaAplicacaoCliente(List<Aplicacao> aplicacao, int codCliente)
        {
            List<Aplicacao> aplicacaoCod = new List<Aplicacao>();

            for (int i = 0; i < aplicacao.Count(); i++)
            {
                if (codCliente.Equals(aplicacao[i].getCodCliente()))
                {
                    aplicacaoCod.Add(aplicacao[i]);
                }
            }
            return aplicacaoCod;
        }
    }
}
