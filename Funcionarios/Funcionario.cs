namespace bytebank.Funcionarios
{
    public class Funcionario
    {
        // private int _tipo;

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salraio { get; set; }
        
        public double getBonificacao()
        {
            return Salario * .1;
        }
    }
}