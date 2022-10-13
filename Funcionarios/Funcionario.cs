namespace bytebank.Funcionarios
{
    public class Funcionario
    {
        
        public string cpf; 
        public string nome;
        public string salario;

        public double getBonificacao()
        {
            return salario *.1;
        }
    }
}