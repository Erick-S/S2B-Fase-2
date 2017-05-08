namespace Laboratorio7
{
    class TermometroEletrico : Termometro, IEstadoBinario
    {
        #region Fields
        private bool ligado;
        #endregion

        #region Properties
        public EstadoBinario Estado
        {
            get
            {
                if (ligado) return EstadoBinario.Ligado;
                else return EstadoBinario.Desligado;
            }
        }
        #endregion

        #region Constructor
        public TermometroEletrico() : base()
        {
            ligado = false;
        }
        #endregion

        #region Methods
        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false;
        }
        #endregion
    }
}
