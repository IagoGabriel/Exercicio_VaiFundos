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
        private String endereco;
        private String cpf;
        private String telefone;
        private DateTime dataCadastro;

        public Cliente(int increment, string nome, string endereco, string cpf, string telefone, DateTime dataCadastro) {

            this.codCliente = increment+1;
            this.nome = nome;
            this.endereco = endereco;
            this.cpf = cpf;
            this.telefone = telefone;
            this.dataCadastro = dataCadastro;
        
        }

        public int getCodCliente() {
            return codCliente;
        }

        public void setNome(string nome){
            this.nome = nome;
        }

        public string getNome() {
            return nome;
        }

        public void setEndereco(string endereco) {
            this.endereco = endereco;
        }

        public string getEndereco(){
            return endereco;
        } 
        
        public void setCpf(string cpf) {
            this.cpf = cpf;
        }

        public string getCpf(){
            return cpf;
        } 

        public void setTelefone(string telefone) {
            this.telefone = telefone;
        }

        public string getTelefone(){
            return telefone;
        }

        public void setDataCadastro(DateTime dataCadastro)
        {
            this.dataCadastro = dataCadastro;
        }

        public DateTime getdataCadastro(){
            return dataCadastro;
        }

        public static void imprimeListaCliente(List<Cliente> clientes)
        {
            for (int i = 0; i < clientes.Count(); i++ )
            {
                Console.WriteLine("\nCódigo: {0}\nNome: {1}\nEndereço: {2}\nCPF: {3}\nTelefone: {4}\nData de cadastro: {5}\n", clientes[i].codCliente, clientes[i].nome, clientes[i].endereco, clientes[i].cpf, clientes[i].telefone, clientes[i].dataCadastro.ToShortDateString());
            }
        }

        public static void lerArquivo(List<Cliente> clientes)
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
                    clientePadrao = new Cliente(clientes.Count(), separador[1], separador[2], separador[3], separador[4], DateTime.Parse(separador[5]));
                    linha = leitor.ReadLine();
                    clientes.Add(clientePadrao);
                }
                

                leitor.Close();
                arqDados.Close();
            }
        }

        public static void escreveArquivo(List<Cliente> clientes)
        {
            FileStream arqDados = new FileStream("../../clientes.txt", FileMode.Create, FileAccess.Write);
            StreamWriter escritor = new StreamWriter(arqDados, Encoding.UTF8);

            for (int i = 0; i < clientes.Count();i++)
            {
                escritor.WriteLine(clientes[i].codCliente + ";" + clientes[i].nome + ";" + clientes[i].endereco + ";" + clientes[i].cpf + ";" + clientes[i].telefone + ";" + clientes[i].dataCadastro.ToShortDateString());
            }


            escritor.Close();
            arqDados.Close();

        }


    }


}
