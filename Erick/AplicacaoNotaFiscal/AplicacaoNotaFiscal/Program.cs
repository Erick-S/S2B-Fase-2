using System;

namespace AplicacaoNotaFiscal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cliente c1 = new Cliente(140, "Joao");
            Cliente c2 = new Cliente(149, "Maria");

            Produto p1 = new Produto(11, "Carvao 10kg", 12.0);
            Produto p2 = new Produto(22, "Arroz agulinha", 2.0);
            Produto p3 = new Produto(33, "Cerveja pack 12uni", 32.0);
            Produto p4 = new Produto(44, "Sal de frutas ENO", 7.0);
            Produto p5 = new ProdutoEE(55, "Churrasqueira Eletrica", 500.0);

            NotaFiscal nota1 = new NotaFiscal(c1);
            nota1.Add(1, p1);
            nota1.Add(2, p2);
            nota1.Add(3, p4);
            nota1.Add(1, p5);

            Console.WriteLine(nota1.GerarNota());

            Console.ReadLine();
        }
    }
}
