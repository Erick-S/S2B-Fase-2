namespace Laboratorio7
{
    class Lampada : IEstadoBinario
    {
        #region Fields
        private bool ligado;
        private int voltagem;
        private int potencia;
        #endregion

        #region Properties
        public bool Ligado { get; }
        public int Voltagem { get; }
        public int Potencia { get; }
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
        public Lampada(int v, int p)
        {
            ligado = false;
            voltagem = v;
            potencia = p;
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
