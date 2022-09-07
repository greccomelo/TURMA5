namespace SISTEMA
{
    public abstract class Pessoa
    {
        //atributos
        public string? nome { get; set; }

        public Endereco? endereco { get; set; }

        
        //metodos
        public abstract float PagarImposto(float rendimento);

public void VerificarPastaArquivo(string caminho){
            string pasta = caminho.Split("/")[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);

            }

            if(!File.Exists(caminho)){
                using(File.Create(caminho))
                {
                    
                }

            }
        }
    }
}