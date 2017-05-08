using System;

namespace Laboratorio8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            string[] lista = { "Julio", "Lucia", "Daniel", "Joao" };
            Console.WriteLine("Array antes da ordenação: ");
            foreach (string pessoa in lista)
            {
                Console.Write("{0}, ", pessoa);
            }
            Array.Sort(lista);
            Console.WriteLine("\nArray depois da ordenação");
            foreach (string pessoa in lista)
            {
                Console.Write("{0}, ", pessoa);
            }
            Console.ReadLine();
            #endregion

            #region Parte 2
            Pessoa[] lista2 =
            {
                new Pessoa("Jose", 25),
                new Pessoa("Ana", 28),
                new Pessoa("Paulo", 20)
            };
            Array.Sort(lista2);  
            foreach (Pessoa pessoa in lista2)
            {
                Console.Write("Nome: {0};",pessoa.Nome);
            }
            Console.ReadLine();
            #endregion
        }
    }
}
