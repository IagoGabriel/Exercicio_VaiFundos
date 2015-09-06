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
            int opcao = -1, opcaoBanco = -1, opcaoInvestimento = -1;

            /*Console.WriteLine("Clientes já cadastrados:");
            Cliente.imprimeListaCliente(clientes);*/

            Console.WriteLine("Por favor, selecione a opção:");
            Console.WriteLine("1 - Banco."); //TERÁ DE VALIDAR SE É O BANCO MESMO
            Console.WriteLine("2 - Cliente."); //TERÁ DE VALIDAR SE É O CLIENTE MESMO
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("1 - Cadastrar clientes.");
                Console.WriteLine("2 - Remover cliente.");
                Console.WriteLine("3 - Cadastrar moeda.");
                Console.WriteLine("4 - Remover moeda.");
                opcaoBanco = int.Parse(Console.ReadLine());

                while (opcaoBanco > 0)
                {
                    if (opcaoBanco == 1)
                    {
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
                        Console.WriteLine("1 - Cadastrar clientes.");
                        Console.WriteLine("2 - Remover cliente.");
                        Console.WriteLine("3 - Cadastrar moeda.");
                        Console.WriteLine("4 - Remover moeda.");
                        opcaoBanco = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        if (opcao==2)
                        {
                            //Método para excluir o cliente caso ele queira encerrar a conta.
                            //Terá essa opção?
                        }
                    }
                    Console.WriteLine("1 - Cadastrar clientes.");
                    Console.WriteLine("2 - Remover cliente.");
                    opcaoBanco = int.Parse(Console.ReadLine());
                }

            }
            else
            {
                if (opcao==2)
                {
                    Console.WriteLine("Por favor, digite o nome: ");
                    nome = Convert.ToString(Console.ReadLine());
                    if (nome.Equals(clientePadrao.getNome()))
                    {
                        Console.WriteLine("1 - Investimento.");
                        Console.WriteLine("2 - Resgate.");
                        Console.WriteLine("3 - Histórico.");
                    }
                }
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

