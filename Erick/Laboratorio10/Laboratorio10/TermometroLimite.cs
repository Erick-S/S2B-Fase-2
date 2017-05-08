using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio10
{
    class TermometroLimite : Termometro
    {
        private double limiteSuperior;
        private bool disparadoEventoLimiteSuperior;

        public delegate void MeuDelegate(string msg, double temp);

        public event MeuDelegate LimiteSuperiorEvent;

        private void OnLimiteSuperiorEvent()
        {
            // verifica se a temperatura ultrapassou o limite e
            // Verifica se o evento já foi disparado, para não disparar continuamente.
            if ((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
                // verifica se há tratador
                if (LimiteSuperiorEvent != null)
                {
                    LimiteSuperiorEvent("Atenção: temperatura acima do limite!!!", this.Temperatura);
                    disparadoEventoLimiteSuperior = true;
                }
            if ((Temperatura < LimiteSuperior) && (disparadoEventoLimiteSuperior))
            {
                LimiteSuperiorEvent("Atenção: temperatura retornou abaixo do limite...", Temperatura);
                disparadoEventoLimiteSuperior = false;
            }
        }

        public TermometroLimite(double ls)
        {
            limiteSuperior = ls;
            disparadoEventoLimiteSuperior = false;
        }

        public double LimiteSuperior
        {
            get { return limiteSuperior; }
            set { limiteSuperior = value; }
        }

        public override void Aumentar()
        {
            base.Aumentar();
            OnLimiteSuperiorEvent();
        }
        public override void Aumentar(double quantia)
        {
            base.Aumentar(quantia);
            OnLimiteSuperiorEvent();
        }

        public override void Diminuir()
        {
            base.Diminuir();
            //if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            //{
            //    disparadoEventoLimiteSuperior = false;
            //}
            OnLimiteSuperiorEvent();
        }
        public override void Diminuir(double quantia)
        {
            base.Diminuir(quantia);
            //if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            //{
            //    disparadoEventoLimiteSuperior = false;
            //}
            OnLimiteSuperiorEvent();
        }
    }
}
