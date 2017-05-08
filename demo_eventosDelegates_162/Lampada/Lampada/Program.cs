using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lampadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampada l1 = new Lampada();
            Lampada l2 = new Lampada();
            Lampada l3 = new Lampada();
            l1.inicializa();
            l2.inicializa();
            l1.acende();
            l3.acende();
            l2.acende();
            l1.apaga();
            l3.queima();
            Console.WriteLine(l1.getEstado());
            Console.WriteLine(l2.getEstado());
            Console.WriteLine(l3.getEstado());

            TestaParametros tp = new TestaParametros();
            tp.inicializa(100);
            int aux = tp.getValor();
            Console.WriteLine(aux);

            int aux2;
            tp.getValor2(out aux2);
            Console.WriteLine(aux2);

        }
    }
}
