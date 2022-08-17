namespace SISTEMA
{
    public abstract class Pessoa
    {
        //atributos
        public string? nome { get; set; }

        public Endereco? endereco { get; set; }

        
        //metodos
        public abstract void PagarImposto(float rendimento);
    }
}