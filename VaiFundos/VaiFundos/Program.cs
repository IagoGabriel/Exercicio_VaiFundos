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

            FundoInvestimento.lerArquivo(fundoInvestimento, moedas[0], moedas[1]);
            Cliente.lerArquivo(clientes);

            Real real = new Real(2, "real", "R$");
            Dolar dolar = new Dolar(3, "dolar", "U$");

            moedas.Add(real);
            moedas.Add(dolar);
            
            Aplicacao aplicacao = null;
            Cliente clientePadrao = null;
            FundoInvestimento novo = null;

            int opcao = -1, opcaoBanco = -1, opcaoCliente = -1, cpf;            
            String nome, senha, endereco, telefone;
           

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
                                cpf = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o telefone do {0}º cliente: ", i + 1);
                                telefone = Console.ReadLine();

                                clientePadrao = new Cliente(clientes.Count(), nome, senha, endereco, cpf, telefone, DateTime.Now);
                                clientes.Add(clientePadrao);
                            }
                            Console.WriteLine("1 - Cadastrar clientes.");
                            Console.WriteLine("2 - Remover cliente.");
                            Console.WriteLine("3 - Cadastrar fundos de investimento.");
                            Console.WriteLine("4 - Remover fundos de investimento.");
                            Console.WriteLine("5 - Realizar Aplicação.");
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
                                            Console.WriteLine("Fundo não existe! Favor inserir um novo código: ");
                                            codFundo = int.Parse(Console.ReadLine());
                                        }

                                        Console.WriteLine("Tem certeza que deseja excluir esse fundo {0}?", FundoInvestimento.buscaFundo(fundoInvestimento, codFundo).getNome());
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
                                        
                                    }
                                }
                            }
                        }

                        Console.WriteLine("1 - Cadastrar clientes.");
                        Console.WriteLine("2 - Remover cliente.");
                        Console.WriteLine("3 - Cadastrar fundos de investimento.");
                        Console.WriteLine("4 - Remover fundos de investimento.");
                        opcaoBanco = int.Parse(Console.ReadLine());

                    }
                }
                else
                {
                    if (opcao == 2)
                    {
                        Console.WriteLine("Por favor, digite os dados: ");
                        Console.WriteLine("CPF: ");
                        String tempCpf = Console.ReadLine().Replace(".", "");
                        tempCpf = tempCpf.Replace("-", "");
                        int cpfCliente = int.Parse(tempCpf);
                        while (Cliente.buscaClienteCpf(clientes, cpfCliente) == null)
                        {
                            Console.WriteLine("Esse CPF {0} não existe! Favor inserir um novo CPF: ", cpfCliente);
                            cpfCliente = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("Senha: ");
                        String senhaCliente = Convert.ToString(Console.ReadLine());
                        while(!(senhaCliente.Equals(Cliente.buscaCliente(clientes, cpfCliente).getSenha())))
                        {
                            Console.WriteLine("Senha incorreta! Favor digitar a senha: ");
                            senhaCliente = Convert.ToString(Console.ReadLine());
                        }

                        if((senhaCliente.Equals(Cliente.buscaCliente(clientes, cpfCliente).getSenha()))){

                            Console.WriteLine("1 - Realizar aplicação.");
                            Console.WriteLine("2 - Realizar resgate.");
                            Console.WriteLine("3 - Histórico de aplicações.");
                            Console.WriteLine("3 - Histórico de resgates.");
                            opcaoCliente = int.Parse(Console.ReadLine());

                            if(opcaoCliente == 1){
                                Console.WriteLine("Aplicação: ");
                                Console.WriteLine("Por favor, digite o valor a ser aplicacado: ");
                                float valorAplicacao = int.Parse(Console.ReadLine());
                                Console.WriteLine("Por favor, digite o código do Fundo de Investimento que deseja aplicar: ");
                                FundoInvestimento.imprimeListaFundos(fundoInvestimento);
                                int codInvestimento = int.Parse(Console.ReadLine());                        

                                while(FundoInvestimento.buscaFundo(fundoInvestimento, codInvestimento) == null){
                                        Console.WriteLine("Fundo não existe! Favor inserir um novo código: ");
                                        codInvestimento = int.Parse(Console.ReadLine());
                                }

                                aplicacao = new Aplicacao(valorAplicacao, codInvestimento);

                                Console.WriteLine("{0}, tem certeza que deseja incluir essa aplicação de R${1} nesse fundo {2}?", Cliente.buscaCliente(clientes, cpfCliente).getNome(), valorAplicacao, FundoInvestimento.buscaFundo(fundoInvestimento, codInvestimento).getNome());
                                Console.WriteLine("1 - Sim.");
                                Console.WriteLine("2 - Não.");
                                int incluiAplicacao = int.Parse(Console.ReadLine());

                                if(incluiAplicacao == 1)
                                {
                                    Cliente.buscaCliente(clientes, cpfCliente).getNome())
                                    FundoInvestimento.escreveArquivo(fundoInvestimento);
                                }

                            

                                        

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
            }


            Console.ReadKey();

        }
    }
}