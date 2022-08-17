namespace SISTEMA
{
    class Program
    {
        static void Main(string[] args)
        {
            // colar aqui novamente depois o código do bloco de notas

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@$"
            
            ===================================
            |                                 |
            | Seja Bem vindo ao nosso sistema |
            |    de cadastro de pessoas       |
            |      Físicas e Jurídicas        |
            |                                 |
            ===================================

            ");

            Console.ResetColor();

            Console.Write("Iniciando...");
            Thread.Sleep(500);

            for (var contador = 0; contador < 10; contador++)
            {
                Console.Write("#");
                Thread.Sleep(500);
            }
            Console.Clear();

            string? opcao;

            do
            {
                Console.WriteLine(@$"
            
            ===================================
            |  ESCOLHA UMA DAS OPÇÕES ABAIXO  |
            ===================================
            |                                 |
            | 1- Pessoa Física                |
            | 2- Pessoa Jurídica              |
            | 0- Sair                         |
            |                                 |
            ===================================

            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Saiu");
                        break;
                }

            } while (opcao != "0");

            Console.ResetColor();

            // recortar até aqui e colar do bloco de nota
        }
    }
}


