using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidade
{
    internal class ContaPoupanca : Conta
    {
        public override void Sacar(double value)
        {
            saldo = saldo - value - (value * 0.2);
            Console.WriteLine("Saldo apos saque R$" + saldo);

        }
    }
}
