using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            //List<string> listaStrings = new List<string>();
            //listaStrings.Add("Um");
            //listaStrings.Add("Hello");
            //listaStrings.Add("World");
            //Console.WriteLine(listaStrings[0]);
            //Console.WriteLine(listaStrings[1]);
            //Console.WriteLine(listaStrings[2]);
            ////listaStrings.Add(10);
            //Console.ReadLine();

            //Queue<Object> q = new Queue<Object>();
            //q.Enqueue(".Net Framework");
            //q.Enqueue(new Decimal(123.456));
            //q.Enqueue(654.321);
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Dequeue());
            //Console.ReadLine();

            //Queue<int> minhaFila = new Queue<int>();
            //minhaFila.Enqueue(10);
            //minhaFila.Enqueue(200);
            //minhaFila.Enqueue(1000);
            //Console.WriteLine(minhaFila.Dequeue());
            //Console.WriteLine(minhaFila.Dequeue());
            //Console.WriteLine(minhaFila.Dequeue());
            //Console.ReadLine();

            //Dictionary<int, string> paises = new Dictionary<int, string>();
            //paises[44] = "Reino Unido";
            //paises[33] = "França";
            //paises[55] = "Brasil";
            //Console.WriteLine("O código 55 é: {0}", paises[55]);
            //foreach (KeyValuePair<int, string> item in paises)
            //{
            //    int codigo = item.Key;
            //    string pais = item.Value;
            //    Console.WriteLine("Código {0} = {1}", codigo, pais);
            //}
            //Console.ReadLine();
            #endregion

            #region Exercicio 1
            Dictionary<string, string> codigoDDI = new Dictionary<string, string>();
            codigoDDI["Afeganistao"] = "93";
            codigoDDI["Africa do Sul"] = "27";
            codigoDDI["Albania"] = "355";
            //...
            Console.WriteLine("Código DDI de Albania: {0}", codigoDDI["Albania"]);
            Console.ReadLine();
            #endregion

            #region Exercicio 2
            List<int> numeros = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                numeros.Add(i);
            }
            Console.Write("Números acima da média: ");
            //int acima = 0;
            //foreach(int x in numeros)
            //{
            //    if(x > numeros.Average())
            //    {
            //        acima++;
            //    }
            //}
            //Console.WriteLine(acima);
            var result = numeros.FindAll(v => v > numeros.Average()); //Finds all that match query
            var result2 = numeros.Where(v => v > numeros.Average()); //Finds value(s) that match query...?
            Console.WriteLine(result.Count);
            Console.WriteLine("Média: {0}", numeros.Average());
            Console.ReadLine();
            #endregion

            #region Exercicio 3
            List<int> listaAcimaMedia = new List<int>();
            Console.WriteLine("Lista de números acima da média:");
            foreach (int x in numeros)
            {
                if (x > numeros.Average())
                {
                    listaAcimaMedia.Add(x);
                }
            }
            foreach(int x in listaAcimaMedia)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
            #endregion
        }
    }
}
