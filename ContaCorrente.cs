using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public string conta;
        public int numero_agencia;
        public double saldo;

        public void Depositar(double valor)
        {
            this.saldo += valor;

        }

        public bool Sacar(double valor)
        {
            if(valor <= saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool Transeferir (double valor, ContaCorrente destino)
        {
            if (this.saldo <= valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        
    }
}