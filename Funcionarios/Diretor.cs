namespace bytebank.Funcionarios
{
    public class Diretor:Funcionario
    {
        public override double getBonificacao()
        {
            return Salario + base.getBonificacao();  
        }
    
    }
}