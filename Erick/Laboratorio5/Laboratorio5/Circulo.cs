
using System;

namespace Laboratorio5
{
    class Circulo
    {
        public double CoordX { get; private set; }
        public double CoordY { get; private set; }
        public double Raio { get; private set; }

        public Circulo(double x, double y, double r)
        {
            CoordX = x;
            CoordY = y;
            Raio = Math.Abs(r);
        }

        public Circulo() : this(0, 0, 1) { }

        public override string ToString()
        {
            return "("+string.Format("{0:F2}", CoordX)+";"+string.Format("{0:F2}", CoordY)+")"+"raio="+string.Format("{0:F2}", Raio);
        }
    }
}
