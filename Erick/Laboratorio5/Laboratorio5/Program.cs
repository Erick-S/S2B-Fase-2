using System;

namespace Laboratorio5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            Circulo circ1 = new Circulo();
            //Console.WriteLine(circ1);
            //Console.ReadLine();
            Circulo circ2 = new Circulo(2.4, 5, 3);
            //Console.WriteLine(circ2);
            //Console.ReadLine();
            CirculoColorido circ3 = new CirculoColorido();
            //Console.WriteLine(circ3);
            //Console.ReadLine();
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            //Console.WriteLine(circ4);
            //Console.ReadLine();
            CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido();
            //Console.WriteLine(circ5);
            //Console.ReadLine();
            CirculoColoridoPreenchido circ6 = new CirculoColoridoPreenchido(5, 10, 3, "azul", "branco");
            //Console.WriteLine(circ6);
            //Console.ReadLine();
            #endregion

            #region Parte 2
            Circulo[] circulos = new Circulo[6];
            circulos.SetValue(circ1, 0);
            circulos.SetValue(circ2, 1);
            circulos.SetValue(circ3, 2);
            circulos.SetValue(circ4, 3);
            circulos.SetValue(circ5, 4);
            circulos.SetValue(circ6, 5);
            foreach (Circulo circulo in circulos)
            {
                Console.WriteLine(circulo);
                Console.ReadLine();
            }
            #endregion
        }
    }
}
