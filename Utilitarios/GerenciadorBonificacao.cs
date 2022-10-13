namespace bytebank.Utilitarios
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao { get; set; }
        public void Registrar (Funcionario funcionario)
        {
            this.totalBonificacao += Funcionario.getBonificacao();
        }

        public void Diretor (Diretor diretor)
        {
            this.totalBonificacao += diretor.getBonificacao();
        }

        public double getBonificacao();
        {
            return this.totalBonificacao;
        }
    }

}