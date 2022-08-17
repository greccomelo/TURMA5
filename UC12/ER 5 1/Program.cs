namespace SISTEMA
{
    class Program
    {
        static void Main(string[] args)
        {
            // colar aqui novamente depois o código do bloco de notas

            /*      Endereco end = new Endereco();
                    end.logradouro = "Rua X";
                    end.numero = 100;
                    end.complemento = "Qualquer coisa";
                    end.enderecoComercial = false;

                    PessoaFisica pf = new PessoaFisica();
                    pf.endereco = end;
                    pf.nome = "Caique Zanetti";
                    pf.cpf = "654125";
                    pf.dataNascimento = new DateTime(1994,05,19);

                Console.WriteLine($"O {pf.nome} mora na {pf.endereco.logradouro} número {end.numero}");

                bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

                Console.WriteLine(idadeValida);

                if (idadeValida == true)
                {
                    System.Console.WriteLine("Cadastro liberado");
                }else{
                    Console.WriteLine($"Cadastro Reprovado");

                }
            */

            PessoaJuridica pj = new PessoaJuridica();

            Endereco end = new Endereco();

            end.logradouro = "Rua X";
            end.numero = 100;
            end.complemento = "Qualquer coisa";
            end.enderecoComercial = false;

            pj.endereco = end;
            pj.cnpj = "12345678990001";
            pj.RazaoSocial = "Pessoa Jurídica";

            bool cnpjvalido = pj.ValidarCNPJ(pj.cnpj);
            
            if (pj.ValidarCNPJ(pj.cnpj)){
                Console.WriteLine("CNPJ válido");
            }else{
                Console.WriteLine("CNPJ inválido");
            } 

            // recortar até aqui e colar do bloco de nota
        }
    }
}


