namespace Laboratorio6
{
    public abstract class Conta
    {
        #region Fields
        private decimal saldo;
        private string titular;
        #endregion

        #region Proprieties
        public decimal Saldo { get; set; }
        public string Titular { get; set; }
        public abstract string Id { get; }
        #endregion

        #region Constructor
        public Conta(string t)
        {
            Titular = t;
        }
        #endregion

        #region Methods
        public virtual void Depositar(decimal val)
        {
            Saldo += val;
        }

        public virtual void Sacar(decimal val)
        {
            Saldo -= val;
        }
        #endregion
    }
}
