using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio10
{
    class Program
    {
        private static void TrataLimiteSuperior(string msg, double temp)
        {
            Console.WriteLine(msg+"\n Temperatura atual: {0}", temp);
        }

        static void Main(string[] args)
        {
            #region Parte 1
            // inicializa o termometro e mostra seu valor
            TermometroLimite term = new TermometroLimite(5);
            Console.WriteLine(term.ToString());
            // adiciona um tratador ao evento LimiteSuperiorEvent
            term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);
            // aumentar a temperatura além do limite
            term.Aumentar(6);
            Console.WriteLine(term.ToString());
            Console.ReadLine();
            #endregion

            #region Exercicio 1
            term.Diminuir(2);
            Console.WriteLine(term.ToString());
            Console.ReadLine();
            #endregion
        }
    }
}
