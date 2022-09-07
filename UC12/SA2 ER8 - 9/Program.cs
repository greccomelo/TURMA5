namespace SISTEMA
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            List<PessoaFisica> listaPf = new List<PessoaFisica>();
            static void BarraCarregamento(string texto)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write(texto);
                Thread.Sleep(200);

                for (var contador = 0; contador < 10; contador++)
                {
                    Console.Write("▓");
                    Thread.Sleep(200);
                }
            }

            Console.Clear();

            Console.WriteLine(@$"
            
            ===================================
            |                                 |
            | Seja Bem vindo ao nosso sistema |
            |    de cadastro de pessoas       |
            |      Físicas e Jurídicas        |
            |                                 |
            ===================================

            ");
            BarraCarregamento("Iniciando... ");

            Console.ResetColor();



            Console.Clear();

            string? opcao;

            do
            {
                Console.WriteLine(@$"
            
            ===================================
            |  ESCOLHA UMA DAS OPÇÕES ABAIXO  |
            ===================================
            |                                 |
            |       PESSOA FÍSICA             |
            |   1 - Cadastrar Pessoa Física   |
            |   2 - Listar Pessoa Física      |
            |   3 - Remover Pessoa Física     |
            |                                 |
            |       PESSOA JURÍDICA           |
            |   4 - Cadastrar Pessoa Jurídica |
            |   5 - Listar Pessoa Jurídica    |
            |   6 - Remover Pessoa Jurídica   |
            |                                 |
            ===================================
            |           0- Sair               |
            ===================================

            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //Cadastrar Pessoa Física

                        PessoaFisica pf = new PessoaFisica();

                        /*                       Endereco endPf = new Endereco();

                                                Console.WriteLine("Digite seu logradouro: ");
                                                endPf.logradouro = Console.ReadLine();

                                                Console.WriteLine("Digite o número: ");
                                                endPf.numero = int.Parse(Console.ReadLine());

                                                Console.WriteLine("Digite o complemento (caso exista): ");
                                                endPf.complemento = Console.ReadLine();

                                                Console.WriteLine("Endereço é Comercial? s/n");
                                                string endComercial = Console.ReadLine().ToUpper();

                                                if (endComercial == "s")
                                                {
                                                    endPf.enderecoComercial = true;
                                                }
                                                else
                                                {
                                                    endPf.enderecoComercial = false;
                                                }

                                                pf.endereco = endPf;
                        */

                        Console.WriteLine("Digite seu Nome: ");
                        pf.nome = Console.ReadLine();

                        Console.WriteLine("Digite seu CPF (somente números): ");
                        pf.cpf = Console.ReadLine();

                        /*                       Console.WriteLine("Digite seu Salário: ");
                        pf.salario = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite sua data de aniversário (AAAA, MM, DD): ");
                        pf.dataNascimento = DateTime.Parse(Console.ReadLine());

                        bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);
                        if (idadeValida == true)
                        {
                        Console.WriteLine($"Cadastro Aprovado");
                        listaPf.Add(pf);
                        Console.WriteLine(pf.PagarImposto(pf.salario));
                        }
                        */
                        //StreamWriter sw = new StreamWriter($"{pf.nome}.txt");
                        //sw.Write($"{pf.nome}");
                        //sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{pf.nome}.txt"))
                        {
                            sw.Write($"Nome: {pf.nome}, CPF: {pf.cpf}");
                        }

                        break;

                    case "2":
                        //Listar Pessoa Física

                        Console.WriteLine($"Digite o nome que deseja pesquisar: ");
                        string pessoa = Console.ReadLine();

                        using (StreamReader sr = new StreamReader($"{pessoa}.txt"))
                        {
                            string linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }

                            Console.WriteLine($"Aperte 'Enter' para prosseguir...");
                            Console.ReadLine();

                        }
                        //foreach (var cadaItem in listaPf)
                        //{
                        //    Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}");
                        //}
                        break;

                    case "3":
                        //Remover Pessoa Física
                        Console.WriteLine($"Digite o CPF da pessoa que deseja remover: ");
                        string cpfProcurado = Console.ReadLine();
                        PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

                        if (pessoaEncontrada != null)
                        {
                            listaPf.Remove(pessoaEncontrada);
                            Console.WriteLine($"Pilantra removido!!!");
                        }
                        else
                        {
                            Console.WriteLine($"Pilantra não encontrado");
                        }
                        break;

                    case "4":
                        //Cadastrar pessoa juridica
                        novaPj.nome = "Bruno Grecco e Melo";
                        novaPj.cnpj = "01.958.357/0001-20";
                        novaPj.RazaoSocial = "Qualy Distribuidora";

                        novoEndPj.logradouro = "Italo Consoli";
                        novoEndPj.numero = 148;
                        novoEndPj.complemento = "Alvorada";
                        novoEndPj.enderecoComercial = true;

                        novaPj.endereco = novoEndPj;

                        metodoPj.Inserir(novaPj);

                        break;

                    case "5":
                        // Listar pessoa juridica
                        List<PessoaJuridica> listapj = metodoPj.Ler();
                        foreach (PessoaJuridica cadaItem in listapj)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                            Nome: {novaPj.nome}
                            Razão Social: {novaPj.RazaoSocial}
                            CNPJ: {novaPj.RazaoSocial}
                            
                            ");
                        }
                        Console.WriteLine($"Aperte 'Enter' para continuar...");
                        Console.ReadLine();

                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("Obrigado por utilizar o sistema");
                        Console.WriteLine();
                        Thread.Sleep(500);
                        BarraCarregamento("Finalizando... ");
                        Console.Clear();

                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        Thread.Sleep(500);
                        break;
                }

            } while (opcao != "0");

            Console.ResetColor();

        }
    }
}


