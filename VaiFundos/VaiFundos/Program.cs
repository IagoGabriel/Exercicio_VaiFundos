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
            List<Moeda> moedas = new List<Moeda>();
            List<FundoInvestimento> fundoInvestimento = new List<FundoInvestimento>();
            List<Aplicacao> aplicacao = new List <Aplicacao>();

            Real real = new Real(2, "real", "R$");
            Dolar dolar = new Dolar(3, "dolar", "U$");

            moedas.Add(real);
            moedas.Add(dolar);

            Cliente clientePadrao = null;
            String nome, senha, endereco, cpf, telefone;
            Cliente.lerArquivo(clientes);

            FundoInvestimento.lerArquivo(fundoInvestimento, moedas[0], moedas[1]);

            int opcao = -1, opcaoBanco = -1;            

            FundoInvestimento novo = null;

            Console.WriteLine("Por favor, selecione a opção:");
            Console.WriteLine("1 - Banco."); //TERÁ DE VALIDAR SE É O BANCO MESMO
            Console.WriteLine("2 - Cliente."); //TERÁ DE VALIDAR SE É O CLIENTE MESMO
            opcao = int.Parse(Console.ReadLine());

            while (opcao == 1 || opcao == 2)
            {
                if (opcao == 1)
                {
                    Console.WriteLine("1 - Cadastrar clientes.");
                    Console.WriteLine("2 - Remover cliente.");
                    Console.WriteLine("3 - Cadastrar fundos de investimento.");
                    Console.WriteLine("4 - Remover fundos de investimento.");
                    Console.WriteLine("5 - Realizar Aplicação.");
                    opcaoBanco = int.Parse(Console.ReadLine());

                    while (opcaoBanco == 1 || opcaoBanco == 2 || opcaoBanco == 3 || opcaoBanco == 4)
                    {
                        if (opcaoBanco == 1)
                        {
                            for (int i = 0; i < 0; i++)
                            {
                                Console.WriteLine("Digite o nome do {0}º cliente:", i + 1);
                                nome = Console.ReadLine();
                                Console.WriteLine("Digite a senha do {0}º cliente:", i + 1);
                                senha = Console.ReadLine();
                                Console.WriteLine("Digite o endereço completo do {0}º cliente:", i + 1);
                                endereco = Console.ReadLine();
                                Console.WriteLine("Digite o CPF do {0}º cliente:", i + 1);
                                cpf = Console.ReadLine();
                                Console.WriteLine("Digite o telefone do {0}º cliente: ", i + 1);
                                telefone = Console.ReadLine();

                                clientePadrao = new Cliente(clientes.Count(), nome, senha, endereco, cpf, telefone, DateTime.Now);
                                clientes.Add(clientePadrao);
                            }
                            Console.WriteLine("1 - Cadastrar clientes.");
                            Console.WriteLine("2 - Remover cliente.");
                            Console.WriteLine("3 - Cadastrar fundos de investimento.");
                            Console.WriteLine("4 - Remover fundos de investimento.");
                            Console.WriteLine("5 - Realizar Aplicação.")
                            opcaoBanco = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            if (opcaoBanco == 2)
                            {
                                Console.WriteLine("LISTA DE CLIENTES: ");
                                Cliente.imprimeListaCliente(clientes);
                                Console.WriteLine("Por favor, digite o código do cliente a ser removido: ");
                                int codCliente = int.Parse(Console.ReadLine());

                                while (Cliente.buscaCliente(clientes, codCliente) == null)
                                {
                                    Console.WriteLine("Cliente não existe! Favor inserir um novo código: ");
                                    codCliente = int.Parse(Console.ReadLine());
                                }

                                Console.WriteLine("Tem certeza que deseja excluir esse cliente {0}?", Cliente.buscaCliente(clientes, codCliente).getNome());
                                Console.WriteLine("1 - Sim.");
                                Console.WriteLine("2 - Não.");
                                int deletaCliente = int.Parse(Console.ReadLine());

                                if (deletaCliente == 1)
                                {
                                    clientes.Remove(Cliente.buscaCliente(clientes, codCliente));
                                }

                            }
                            else
                            {
                                if (opcaoBanco == 3)
                                {
                                    Console.WriteLine("Digite o nome do fundo de investimento: ");
                                    String nomeInvestimento = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Digite a moeda do fundo de investimento: Real ou Dolar?");
                                    String moedaInvestimento = Convert.ToString(Console.ReadLine());
                                    if (moedaInvestimento.ToLower().Equals("real"))
                                    {
                                         novo = new FundoInvestimento(fundoInvestimento.Count(), nomeInvestimento, real);
                                    }
                                    else
                                    {
                                        if (moedaInvestimento.ToLower().Equals("dolar"))
                                        {
                                            novo = new FundoInvestimento(fundoInvestimento.Count(), nomeInvestimento, dolar);
                                        }
                                    }

                                    fundoInvestimento.Add(novo);
                                    FundoInvestimento.escreveArquivo(fundoInvestimento);
                                }
                                else
                                {
                                    if (opcaoBanco == 4)
                                    {
                                        Console.WriteLine("LISTA DE FUNDOS: ");
                                        FundoInvestimento.imprimeListaFundos(fundoInvestimento);
                                        Console.WriteLine("Por favor, digite o fundo a ser removido: ");
                                        int codFundo = int.Parse(Console.ReadLine());

                                        while (FundoInvestimento.buscaFundo(fundoInvestimento, codFundo) == null)
                                        {
                                            Console.WriteLine("Cliente não existe! Favor inserir um novo código: ");
                                            codFundo = int.Parse(Console.ReadLine());
                                        }

                                        Console.WriteLine("Tem certeza que deseja excluir esse cliente {0}?", FundoInvestimento.buscaFundo(fundoInvestimento, codFundo).getNome());
                                        Console.WriteLine("1 - Sim.");
                                        Console.WriteLine("2 - Não.");
                                        int deletaFundo = int.Parse(Console.ReadLine());

                                        if (deletaFundo == 1)
                                        {
                                            fundoInvestimento.Remove(FundoInvestimento.buscaFundo(fundoInvestimento, codFundo));
                                            FundoInvestimento.escreveArquivo(fundoInvestimento);
                                        }
                                    }
                                    else
                                    {
                                        if(opcaoBanco == 5)
                                        Console.WriteLine("APLICÃÇÃO: ");
                                        Aplicacao.imprimeListaAplicacao(aplicacao);

                                        Console.WriteLine("Por favor, digite o Fundo de Investimento que deseja aplicar: ");
                                        int codInvestimento = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Por favor, digite o valor a ser aplicacado: ");
                                        int valorAplicacao = int.Parse(Console.ReadLine());

                                        

                                        while (Aplicacao.buscaAplicacao(aplicacao, codInvestimento) == null)
                                        {
                                            Console.WriteLine("Aplicação não existe! ");
                                            codInvestimento = int.Parse(Console.ReadLine());
                                        }


                                        // Porque apenas o banco que pode fazer a aplicação, o cliente só leve o cash kk 
                                        // Tem como excluir uma aplicação ? Caso o valor seja errado :S 
                                        Console.WriteLine("Tem certeza que deseja excluir a aplicação {0}?", Aplicacao.buscaAplicacao(aplicacao, codInvestimento);
                                        Console.WriteLine("1 - Sim.");
                                        Console.WriteLine("2 - Não.");
                                        int deletaAplicacao= int.Parse(Console.ReadLine());

                                        if (deletaAplicacao == 1)
                                        {
                                            
                                            Aplicacao.escreveArquivo(aplicacao);
                                        }
                                    }
                                }
                            }
                        }

                        Console.WriteLine("1 - Cadastrar clientes.");
                        Console.WriteLine("2 - Remover cliente.");
                        Console.WriteLine("3 - Cadastrar fundos de investimento.");
                        Console.WriteLine("4 - Remover fundos de investimento.");
                        Console.WriteLine("5 - Realizar Aplicação.");
                        opcaoBanco = int.Parse(Console.ReadLine());

                    }
                }
                else
                {
                    if (opcao == 2)
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
            }

            Console.ReadKey();

        }
    }
}