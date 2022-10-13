using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public string conta;
        public int numero_agencia;
        public string titular;
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
                this.saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }
        
    }
}