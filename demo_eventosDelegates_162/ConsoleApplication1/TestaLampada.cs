using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Lampadas;

namespace ConsoleApplication1
{
    class TestaLampada
    {
        static void Main(string[] args)
        {
            //Versao 1
            Lampada l1 = new Lampada();
            //l1.inicializa();
            //Console.WriteLine("lampada1: " + l1.situacao());
            //l1.acende();
            //Console.WriteLine("lampada1: " + l1.situacao());
            
            //Versao 2

            l1 = new Lampada();
           
            Console.WriteLine("lampada1: " + l1.situacao());
            l1.acende();
            Console.WriteLine("lampada1: " + l1.situacao());
            l1.queima();
            Console.WriteLine("lampada1: " + l1.situacao());
            l1.apaga();
            Console.WriteLine("lampada1: " + l1.situacao());
            l1 = new Lampada();
            l1.acende();
            Console.WriteLine("lampada1: " + l1.situacao());

            Console.ReadKey();
        }
    }
}
