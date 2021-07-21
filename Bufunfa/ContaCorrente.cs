using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bufunfa
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(int _numeroConta, string _titular) : base(_numeroConta, _titular)
        {
        }

        public void GerarTaxa() => saldo -= 15.90;

        public Boolean sacar(double valor, Boolean cobraCPMF)
        {
            if(cobraCPMF)
            {
                return sacar(valor + valor *.0038);
            }
            else
            {
                return sacar(valor);
            }
        }
    }
}
