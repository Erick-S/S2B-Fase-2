using System;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1 a 2
            //ContaCorrente minhaConta = new ContaCorrente();
            //Console.WriteLine(minhaConta.Saldo);
            //minhaConta.Depositar(100);
            //Console.WriteLine(minhaConta.Saldo);
            //minhaConta.Sacar(50);
            //Console.WriteLine(minhaConta.Saldo);
            //Console.Read();
            #endregion

            #region Parte 3
            //ContaCorrente minhaConta = new ContaCorrente(340);
            //Console.WriteLine(minhaConta.Saldo);
            //minhaConta.Depositar(100);
            //Console.WriteLine(minhaConta.Saldo);
            //minhaConta.Sacar(50);
            //Console.WriteLine(minhaConta.Saldo);
            //Console.Read();
            #endregion

            #region Parte 4 Exercicios
            #region Exercicio 1
            ContaCorrente minhaConta = new ContaCorrente("meuNome", 340);
            Console.WriteLine(minhaConta.Saldo);
            Console.WriteLine(minhaConta.Nome);
            Console.WriteLine(minhaConta.DataCriacao);
            Console.ReadLine();
            #endregion

            #region Exercicio 2 e 3
            ContaCorrente minhaConta2 = new ContaCorrente("outroNome");
            Console.WriteLine(minhaConta2.Saldo);
            minhaConta2.Depositar(100);
            minhaConta2.Sacar(50);
            minhaConta2.Depositar(100);
            minhaConta2.Depositar(100);
            minhaConta2.Sacar(50);
            Console.WriteLine(minhaConta2.Saldo);
            Console.WriteLine(minhaConta2.mediaSaldo);
            Console.ReadLine();
            #endregion
            #endregion
        }
    }
}
