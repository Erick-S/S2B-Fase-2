using System;

namespace Laboratorio5
{
    class CirculoColoridoPreenchido : CirculoColorido
    {
        public string CorDoPreenchimento { get; private set; }

        public CirculoColoridoPreenchido()
        {
            CorDoPreenchimento = "preto";
        }

        public CirculoColoridoPreenchido(double x, double y, double r, string c, string p) : base(x, y, r, c)
        {
            CorDoPreenchimento = p;
        }

        public override string ToString()
        {
            return base.ToString() + " preenchimento=" + CorDoPreenchimento;
        }
    }
}
