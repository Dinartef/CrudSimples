using System;
using System.Linq;
using System.Collections.Generic;

public static class Program
{
    public static void Main(string [] args)
    {
        Conta c = new ContaPoupanca();
        c.saldo = 1000;
        c.Sacar(200);
        c.Depositar(10);

        Conta c1 = new ContaCorrente();
        c1.Saldo = 1000;
        c1.Sacar(200);
        c1.Depositar(10);
    }

}
