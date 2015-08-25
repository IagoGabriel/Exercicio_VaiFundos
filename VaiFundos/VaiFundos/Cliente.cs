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
        private DateTime datacadastro;



        public Cliente(int codCliente, string nome, string endereco, string cpf, string telefone, DateTime datacadastro) {

            this.codCliente = codCliente;
            this.nome = nome;
            this.endereco = endereco;
            this.cpf = cpf;
            this.telefone = telefone;
            this.datacadastro = datacadastro;
        
        }


        public void setCodC1iente(int codCliente){
        this.codCliente = codCliente;
        }

        public int getCodCliente() {
            return codCliente;
        }


        public void setCodCliente(string nome){
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

        public void setDatacadastro(DateTime datacadastro)
        {
            this.datacadastro = datacadastro;
        }

        public DateTime getdatacadastro(){
            return datacadastro;
        }
    }


}
