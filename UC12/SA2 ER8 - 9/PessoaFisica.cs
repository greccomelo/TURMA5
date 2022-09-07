namespace SISTEMA
{
    public class PessoaFisica: Pessoa
    {
        public string? cpf { get; set; }

        public DateTime dataNascimento { get; set; }

        public float salario { get; set; }

        public override float PagarImposto(float salario){
            if(salario <= 1500){
                return 0;                
            }else if(salario >= 1501 && salario <=3000){
                return salario * 3 / 100;
            }else{
                return salario * 5 / 100;;
            }
        }

        public bool ValidarDataNascimento(DateTime dataNascimento){
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNascimento).TotalDays /365;

            if (anos >= 18){
                return true;
            }else{
                return false;
            }
        }
    }
}