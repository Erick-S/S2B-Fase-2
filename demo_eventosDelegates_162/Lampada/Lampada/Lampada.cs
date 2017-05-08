using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lampadas
{
    class Lampada
    {
        public enum EstadoLampada { Aceso, Apagado, Queimado }

        private EstadoLampada estado;

        public void inicializa()
        {
            estado = EstadoLampada.Apagado;
        }

        public void acende()
        {
            if (estado != EstadoLampada.Queimado)
            {
                estado = EstadoLampada.Aceso;
            }
        }

        public void apaga()
        {
            if (estado != EstadoLampada.Queimado)
            {
                estado = EstadoLampada.Apagado;
            }
        }

        public EstadoLampada getEstado()
        {
            return (estado);
        }

        public void queima()
        {
            if (estado == EstadoLampada.Aceso)
            {
                estado = EstadoLampada.Queimado;
            }
        }
    }
}
