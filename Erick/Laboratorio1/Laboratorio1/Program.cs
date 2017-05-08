using System;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab1
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            Int16 i1 = 84;
            Int32 j1 = 92;

            Console.WriteLine("i: {0} j: {1}", i1, j1);
            Console.Read();
            #endregion

            #region Lab2
            Byte b = byte.MaxValue;
            int i = int.MaxValue;
            long l = long.MaxValue;
            Console.WriteLine("Valor máximo de byte: {0}", b);
            Console.WriteLine("Valor máximo de int: {0}", i);
            Console.WriteLine("Valor máximo de long: {0}", l);
            Console.Read();

            string inteiro = "8492";
            int valorStringInteiro = int.Parse(inteiro);
            Console.WriteLine(valorStringInteiro);
            Int64 valor64 = 123456789;
            Int32 valor32 = Convert.ToInt32(valor64);
            Console.WriteLine(valor32);
            Console.Read();

            //string stringInteiroGrande = "999999999999999999999999999999999999999999999";
            //int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande); //System.OverflowException ... Value too large for Int32...
            //Console.WriteLine(valorStringInteiroGrande);
            string stringInteiro = "123456789";
            int valorString;
            bool conversao1 = int.TryParse(stringInteiro, out valorString);
            Console.WriteLine("Conversão efetuada: {0} Valor: {1}", conversao1, valorString);
            string stringInteiroGrande = "999999999999999999999999999999999999999999999";
            int valorStringInteiroGrande;
            bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);
            Console.WriteLine("Conversão efetuada: {0} Valor: {1}", conversao2, valorStringInteiroGrande);
            string stringLetras = "abc";
            double valorStringLetras;
            bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
            Console.WriteLine("Conversão efetuada: {0} Valor {1}", conversao3, valorStringLetras);
            double valorFracionado = 4.7;
            int valorInteiro1 = (int)valorFracionado;
            int valorInteiro2 = Convert.ToInt32(valorFracionado);
            Console.WriteLine("Conversao explicita = {0}", valorInteiro1);
            Console.WriteLine("Conversao metodo Convert = {0}", valorInteiro2);
            Console.Read();


            string first = "Hello ";
            string second = "World";
            string third = first + second;
            Console.WriteLine(third);
            int chSize = third.Length;
            string fourth = "Tamanho = " + chSize;
            Console.WriteLine(fourth);
            Console.WriteLine(third.Substring(0, 5));
            Console.Read();

            DateTime dt = new DateTime(2015, 04, 23);
            string fifth = dt.ToString();
            Console.WriteLine(fifth);
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine(dt.ToLocalTime());
            Console.ReadLine();

            int x = 10;
            double y = 3.4;

            Console.WriteLine("X=" + x + " Y=" + y);
            Console.WriteLine("X={0} Y={1}", x, y);
            Console.Read();
            #endregion

            #region Lab3
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            int a;
            for (a = 0; a < 5; a++)
            {
                Console.WriteLine("Indice = {0} & Valor = {1}", a, array[a]);
            }

            a = 0;
            foreach (int numero in array)
            {
                Console.WriteLine("Indice = {0} & Valor = {1}", a, numero);
                a++;
            }
            Console.Read();

            string[] str = new string[3];
            int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            for (iStr = 0; iStr < 3; iStr++)
            {
                Console.WriteLine("Indice = {0} & Valor = {1}", iStr, str[iStr]);
            }

            iStr = 0;
            foreach (string stringNumero in str)
            {
                Console.WriteLine("Indice = {0} & Valor = {1}", iStr, stringNumero);
            }
            Console.Read();

            DateTime[] dtArray = new DateTime[2];
            int iDate;
            dtArray[0] = new DateTime(2002, 5, 1);
            dtArray[1] = new DateTime(2002, 6, 1);
            for (iDate = 0; iDate < 2; iDate++)
            {
                Console.WriteLine("Indice = {0} & Data = {1}", iDate, dtArray[iDate].ToString());
            }

            iDate = 0;
            foreach (DateTime date in dtArray)
            {
                Console.WriteLine("Indice = {0} & Data = {1}", iDate, date.ToString());
            }
            Console.Read();
            #endregion
        }
    }
}
