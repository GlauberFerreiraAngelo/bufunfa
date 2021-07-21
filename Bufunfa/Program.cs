using System;

namespace Bufunfa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ContaPoupanca c1 = new ContaPoupanca(1, "glauber");
            ContaPoupanca c2 = new ContaPoupanca(2, "joao");

            

            Console.WriteLine("saldo " + c1.getSaldo());

            c1.depositar(100);
            Console.WriteLine(c1.getTitular() + " saldo " + c1.getSaldo());

            c2.depositar(100);
            Console.WriteLine(c2.getTitular() + " saldo " + c2.getSaldo());

            Console.WriteLine(" Transferir " );
            c1.transferir(c2, 50);

            Console.WriteLine(c1.getTitular() + " saldo " + c1.getSaldo());
            Console.WriteLine(c2.getTitular() + " saldo " + c2.getSaldo());

            c2.sacar(100);
            Console.WriteLine(c2.getTitular() + " saldo " + c2.getSaldo());

        }
    }
}
