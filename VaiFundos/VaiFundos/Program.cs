using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> clientes = new List<Cliente>();
            Cliente clientePadrao;
            String nome, endereco, cpf, telefone;
            Cliente.lerArquivo(clientes);

            Console.WriteLine("Clientes já cadastrados:");
            Cliente.imprimeListaCliente(clientes);

            for (int i = 0; i < 1; i++ )
            {
                Console.WriteLine("Digite o nome do {0}º cliente:", i+1);
                nome = Console.ReadLine();
                Console.WriteLine("Digite o endereço completo do {0}º cliente:", i+1);
                endereco = Console.ReadLine();
                Console.WriteLine("Digite o CPF do {0}º cliente:", i + 1);
                cpf = Console.ReadLine();
                Console.WriteLine("Digite o telefone do {0}º cliente:", i + 1);
                telefone = Console.ReadLine();

                clientePadrao = new Cliente(clientes.Count(), nome, endereco, cpf, telefone, DateTime.Now);
                clientes.Add(clientePadrao);

            }
            
            Cliente.escreveArquivo(clientes);
            Cliente.imprimeListaCliente(clientes);           


            Console.ReadKey();


        }
    }
}
