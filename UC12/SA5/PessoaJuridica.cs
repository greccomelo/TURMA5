namespace SISTEMA
{
    public class PessoaJuridica: Pessoa
    {
        public string? cnpj { get; set; }

        public string? RazaoSocial { get; set; }

        public override void PagarImposto(float rendimento){}
    }
}