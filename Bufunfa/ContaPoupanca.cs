using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bufunfa
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(int _numeroConta, string _titular) : base(_numeroConta, _titular)
        {
        }

        public void GerarTaxa() => saldo += saldo * .006;
        
    }
}
