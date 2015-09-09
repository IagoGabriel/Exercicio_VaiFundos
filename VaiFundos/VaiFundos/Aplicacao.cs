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
        private int  codInvestimento;
        private DateTime dataAplicacao;
        private float rendimento;

        public Aplicacao( float valorAplicacao, int codInvestimento, DateTime dataAplicacao, float rendimento)
        {
            this.valorAplicacao = valorAplicacao;
            this.codInvestimento = codInvestimento;
            this.dataAplicacao = DateTime.Now;
            this.rendimento = 0;
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


        public static void escreveArquivo(List<Aplicacao> aplicacao)
        {
            try
            {

                FileStream arqDados = new FileStream("../../aplicacao.txt", FileMode.Create, FileAccess.Write);
                StreamWriter escritor = new StreamWriter(arqDados, Encoding.UTF8);

                for (int i = 0; i < aplicacao.Count(); i++)
                {
                    escritor.WriteLine(aplicacao[i].valorAplicacao + ";" + aplicacao[i].codInvestimento + ";" + aplicacao[i].dataAplicacao + ";" + aplicacao[i].rendimento + ";");
                }

                escritor.Close();
                arqDados.Close();
            }
            catch (IOException io)
            {
                Console.WriteLine("\nOcorreu um erro: {0}", io);
            }

        }

        public static List<Aplicacao> lerArquivo()
        {
            try
            {
                List<Aplicacao> aplicacao = null; 
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
                       
                            aplicacaoPadrao = new Aplicacao(float.Parse(separador[0]), int.Parse(separador[1]), DateTime.Parse(separador[2]), float.Parse(separador[3]));
                     
                        linha = leitor.ReadLine();
                        aplicacao.Add(aplicacaoPadrao);
                    }
                    
                    leitor.Close();
                    arqDados.Close();
                }
                return aplicacao;
            }
            catch (IOException io)
            {
                Console.WriteLine("\nOcorreu um erro: {0}", io);
                return null;
            }
        }
        public static void imprimeListaAplicacao(List<Aplicacao> aplicacao)
        {
            for (int i = 0; i < aplicacao.Count(); i++)
            {
                Console.WriteLine("\nValor Aplicação: {0}\nCódigo Investimento: {1}\nData Aplicaçao: {2}\nRendimento: {3}\n", aplicacao[i].valorAplicacao, aplicacao[i].codInvestimento,aplicacao[i].dataAplicacao, aplicacao[i].rendimento);
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
                    // paramos aqui pela amor de Deus 
                }
            }

            return null;
        }
    }
}
