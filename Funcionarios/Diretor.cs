namespace bytebank.Funcionarios
{
    public class Diretor
    {
        public string Nome { get; set; }          
        public string Cpf { get; set; }
        public double Salraio { get; set; }

    public double getBonificacao()
    {
        return Salario * .1;  
    }
    
    }
}