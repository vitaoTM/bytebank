namespace bytebank.Funcionarios
{
    public class Funcionario
    {
        private int _tipo;
        public Funcionario(int _tipo)
        {
            this._tipo = _tipo;
        }
        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salraio { get; set; }
        
        public double getBonificacao()
        {
            if (_tipo == 1)
            {
                return Salario;
            }
            else
            {
                return Salario * .1;
            }
        }
    }
}