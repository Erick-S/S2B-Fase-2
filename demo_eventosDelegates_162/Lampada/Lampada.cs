using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lampadas
{
    public enum EstadoLampada { Acesa, Apagada, Queimada };

    public delegate void NotificacaoLampada(String mensagem);

    public class Lampada
    {
    
        private EstadoLampada estado;
        private Random vidaUtil;

        public event NotificacaoLampada LampQueimadaEvento;

        public Lampada()
        {
            this.novaLampada();
        }

        public void novaLampada() {
            estado = EstadoLampada.Apagada;
            vidaUtil = new Random();
            this.valida();
 
        }

        public void acende()
        {
            if (estado == EstadoLampada.Queimada) return;
            estado = EstadoLampada.Acesa;
            this.valida();
        }

        public void queima()
        {
            estado = EstadoLampada.Queimada;
            if (LampQueimadaEvento != null)
                LampQueimadaEvento("lamento muito. queimei....");
        }


        public void apaga()
        {
            if (estado == EstadoLampada.Queimada) return;
            estado = EstadoLampada.Apagada;
            this.valida();
        }

        public EstadoLampada situacao()
        {        
            return estado;
        }

        private void valida()
        {
            int q = vidaUtil.Next(10);
            if (q > 8)
                this.queima();
        }
    }



}
