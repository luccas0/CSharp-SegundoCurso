using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDesafio5_Construtor
{
    public class ContaCorrente
    {
        public string titular;
        public int numero_agencia;
        public string conta;
        public double saldo;

        public ContaCorrente(string titular, int numero_agencia, string conta, double saldo)
        {
            this.titular = titular; 
            this.numero_agencia = numero_agencia;
            this.conta = conta;
            this.saldo = saldo;

        }
    }
}
