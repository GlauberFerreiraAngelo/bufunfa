using Bufunfa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bufunfa
{
    class Conta : IConta
    {
        private int numeroConta { get; set; }
        private String titular { get; set; }
        protected double saldo { get; set; }

        public Conta(int _numeroConta, String _titular)
        {
            numeroConta = _numeroConta;
            titular = _titular;
        }

        public bool depositar(double valor)
        {
            saldo += valor;
            return true;
        }

        public bool sacar(double valor)
        {
            if (valor < saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool transferir(Conta contaDestino, double valor)
        {
            Boolean retirou = sacar(valor);
            if (retirou) 
            {
                contaDestino.depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }

        public double getSaldo()
        {
            return saldo;
        }

        public void setSaldo(double valor)
        {
            saldo = valor;
        }

        public String getTitular()
        {
            return titular;
        }


        public void gerarTaxa() 
        { 
        }
    }
}
