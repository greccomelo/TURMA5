namespace SISTEMA
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa novapessoa = new Pessoa();
            Pessoa novapessoa1 = new Pessoa();
            Pessoa novapessoa2 = new Pessoa();

            novapessoa.Endereco = "Rua X";
            novapessoa.nome = "Bruno";

            novapessoa1.nome = "Fafá";

            novapessoa2.nome = "Lara";

            Console.WriteLine(novapessoa.Endereco);
            Console.WriteLine(novapessoa.nome);
            Console.WriteLine(novapessoa1.nome);
            Console.WriteLine(novapessoa2.nome);
        }
    }
}

