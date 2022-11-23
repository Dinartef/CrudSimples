using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidade
{
    public class Conta
    {
        public double saldo;

        public virtual void Sacar(double value)
        {
            saldo = saldo - value - (value * 0.05);
            Console.WriteLine("Saldo apos saque R$" + saldo);
        }
        public virtual void Depositar(double value)
        {
            saldo = saldo + value;
            Console.WriteLine("Saldo após o Deposito R$" + saldo);
        }
    }
}
