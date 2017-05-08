namespace Laboratorio7
{
    class Termometro
    {
        #region Fields
        private double temperatura;
        #endregion

        #region Properties
        public double Temperatura { get; }
        #endregion

        #region Constructor
        public Termometro()
        {
            temperatura = 0.0;
        }
        #endregion

        #region Methods
        public void Aumentar(double t)
        {
            temperatura += t;
        }

        public void Diminuir(double t)
        {
            temperatura -= t;
        }
        #endregion
    }
}
