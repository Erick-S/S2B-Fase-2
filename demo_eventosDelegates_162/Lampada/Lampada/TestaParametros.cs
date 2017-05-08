using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lampadas
{
    class TestaParametros
    {
        private int valor;

        public void inicializa(int v)
        {
            valor = v;
        }

        public int getValor()
        {
            return (valor);
        }

        public void getValor2(out int val)
        {
            val = valor;
        }
    }
}
