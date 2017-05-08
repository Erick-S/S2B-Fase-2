namespace Laboratorio7
{
    class Radio : IEstadoBinario
    {
        #region Fields
        private bool ligado;
        private string frequencia;
        #endregion

        #region Properties
        public string Frequencia { get; set; }
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
        public Radio()
        {
            ligado = false;
            frequencia = null;
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
