using System;

namespace Laboratorio7
{
    class Program
    {
        static void Main(string[] args)
        {
            IEstadoBinario[] lista = new IEstadoBinario[3];
            lista[0] = new Lampada(110, 60);
            lista[0].Ligar();
            lista[1] = new TermometroEletrico();
            lista[2] = new Radio();
            foreach (IEstadoBinario dispositivo in lista)
            {
                Console.WriteLine("Estado: {0}", dispositivo.Estado);
            }
            Console.ReadLine();
        }
    }
}
