using System;

namespace Laboratorio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new ContaPoupanca(0.01m, DateTime.Now, "Titular 1");
            ContaPoupanca conta2 = new ContaPoupanca(0.02m, DateTime.Now, "Titular 2");
            Conta conta3 = new ContaCorrente("Titular 3");
            conta1.Depositar(500);
            conta1.Sacar(50);
            conta2.Depositar(500);
            conta2.AdicionarRendimento();
            conta2.Sacar(50);
            conta3.Depositar(500);
            conta3.Sacar(50);
            Console.WriteLine("Saldo1 {0:F2} / Saldo2 {1:F2} / Saldo3 {2:F2}", conta1.Saldo, conta2.Saldo, conta3.Saldo);
            Console.ReadLine();
            Conta[] contas = new Conta[2];
            contas[0] = conta1;
            contas[1] = conta3;
            foreach (Conta conta in contas)
            {
                conta.Depositar(500);
                conta.Sacar(50);
                Console.WriteLine(conta.Titular);
                Console.WriteLine(conta.Id);
                Console.WriteLine(conta.Saldo);
                Console.ReadLine();
            }
        }
    }
}
