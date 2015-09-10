using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VaiFundos
{
    class Cliente
    {
        private int codCliente;
        private String nome;
        private String senha;
        private String endereco;
        private int cpf;
        private String telefone;
        private DateTime dataCadastro;
        List<FundoInvestimento> fundoInvestimento = new List<FundoInvestimento>();
        List<Resgate> resgates = new List<Resgate>();

        public Cliente(int increment, String nome, String senha, String endereco, int cpf, String telefone, DateTime dataCadastro)
        {

            this.codCliente = increment + 1;
            this.nome = nome;
            this.senha = senha;
            this.endereco = endereco;
            this.cpf = cpf;
            this.telefone = telefone;
            this.dataCadastro = dataCadastro;

        }


        public int getCodCliente()
        {
            return codCliente;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getNome()
        {
            return nome;
        }

        public String getSenha()
        {
            return senha;
        }

        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }

        public String getEndereco()
        {
            return endereco;
        }

        public void setCpf(int cpf)
        {
            this.cpf = cpf;
        }

        public int getCpf()
        {
            return cpf;
        }

        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        public String getTelefone()
        {
            return telefone;
        }

        public void setDataCadastro(DateTime dataCadastro)
        {
            this.dataCadastro = dataCadastro;
        }

        public DateTime getDataCadastro()
        {
            return dataCadastro;
        }

        public List<Aplicacao> realizarAplicacao(Aplicacao aplicacao, int codInvestimento)
        {
            return FundoInvestimento.buscaFundo(this.fundoInvestimento, codInvestimento).buscaAplicacao();
            
        }

        public static Cliente buscaCliente(List<Cliente> clientes, int codigo)
        {
            for (int i = 0; i < clientes.Count(); i++)
            {
                if (codigo.Equals(clientes[i].getCodCliente()))
                {
                    return clientes[i];
                }
            }

            return null;
        }

        public static Cliente buscaClienteCpf(List<Cliente> clientes, int cpf)
        {
            for (int i = 0; i < clientes.Count(); i++)
            {
                if (cpf.Equals(clientes[i].getCpf()))
                {
                    return clientes[i];
                }
            }

            return null;
        }

        public static void imprimeListaCliente(List<Cliente> clientes)
        {
            for (int i = 0; i < clientes.Count(); i++)
            {
                Console.WriteLine("\nCódigo: {0}\nNome: {1}\nEndereço: {2}\nCPF: {3}\nTelefone: {4}\nData de cadastro: {5}\n", clientes[i].codCliente, clientes[i].nome, clientes[i].endereco, clientes[i].cpf, clientes[i].telefone, clientes[i].dataCadastro.ToShortDateString());
            }
        }

        public static void lerArquivo(List<Cliente> clientes)
        {
            try
            {
                if (File.Exists("../../clientes.txt"))
                {
                    Stream arqDados = File.Open("../../clientes.txt", FileMode.Open);
                    StreamReader leitor = new StreamReader(arqDados);
                    String linha = leitor.ReadLine();
                    String[] separador;
                    Cliente clientePadrao;

                    while (linha != null)
                    {
                        separador = linha.Split(';');
                        clientePadrao = new Cliente(clientes.Count(), separador[1], separador[2], separador[3], int.Parse(separador[4]), separador[5],DateTime.Parse(separador[6]));
                        linha = leitor.ReadLine();
                        clientes.Add(clientePadrao);
                    }


                    leitor.Close();
                    arqDados.Close();
                }
            }catch(IOException io){
                Console.WriteLine("\nOcorreu um erro: {0}", io);
            }
        }

        public static void escreveArquivo(List<Cliente> clientes)
        {
            FileStream arqDados = new FileStream("../../clientes.txt", FileMode.Create, FileAccess.Write);
            StreamWriter escritor = new StreamWriter(arqDados, Encoding.UTF8);

            for (int i = 0; i < clientes.Count(); i++)
            {
                escritor.WriteLine(clientes[i].codCliente + ";" + clientes[i].nome + ";" + clientes[i].senha + ";" + clientes[i].endereco + ";" + clientes[i].cpf + ";" + clientes[i].telefone + ";" + clientes[i].dataCadastro.ToShortDateString());
            }

            escritor.Close();
            arqDados.Close();

        }
    }
}
