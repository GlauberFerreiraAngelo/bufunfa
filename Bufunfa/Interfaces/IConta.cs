using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bufunfa.Interfaces
{
    interface IConta
    {
        public Boolean sacar(double valor);

        public Boolean depositar(double valor);

        Boolean transferir(Conta contaDestino, double valor);
    }
}
