using System;

namespace Laboratorio5
{
    class CirculoColorido : Circulo
    {
        public string MinhaCor { get; private set; }

        public CirculoColorido()
        {
            MinhaCor = "preto";
        }

        public CirculoColorido(double x, double y, double r, string c) : base(x, y, r)
        {
            MinhaCor = c;
        }

        public override string ToString()
        {
            return base.ToString()+" cor="+MinhaCor;
        }
    }
}
