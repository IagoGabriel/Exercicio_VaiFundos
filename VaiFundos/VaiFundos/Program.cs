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

            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine("Digite o nome do {0}º cliente:", i + 1);
                nome = Console.ReadLine();
                Console.WriteLine("Digite o endereço completo do {0}º cliente:", i + 1);
                endereco = Console.ReadLine();
                Console.WriteLine("Digite o CPF do {0}º cliente:", i + 1);
                cpf = Console.ReadLine();
                Console.WriteLine("Digite o telefone do {0}º cliente: ", i + 1);
                telefone = Console.ReadLine();

                clientePadrao = new Cliente(clientes.Count(), nome, endereco, cpf, telefone, DateTime.Now);
                clientes.Add(clientePadrao);
            }

            Cliente.escreveArquivo(clientes);
            Cliente.imprimeListaCliente(clientes);


            

            Moeda moeda = new Moeda(1, "teste", "T$");
            Real real = new Real(2, "real", "R$");
            Dolar dolar = new Dolar(3, "dolar", "U$");

            FundoInvestimento MarianeL2 = new FundoInvestimento(1, "MarianeL2", real);

            Console.WriteLine("Notas: {0} dolar(es)", MarianeL2.getMoeda().getNomeMoeda());


            Console.ReadKey();




        }
    }
}

