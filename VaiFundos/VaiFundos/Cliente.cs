using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("\nCódigo: {0}\nNome: {1}\nEndereço: {2}\nCPF: {3}\nTelefone: {4}\nData de cadastro: {5}\n", clientes[i].codCliente, clientes[i].nome, clientes[i].endereco, clientes[i].cpf, clientes[i].telefone, clientes[i].dataCadastro);

            }

        }



    }


}
