using System;

namespace Laboratorio6
{
    class ContaCorrente : Conta
    {
        #region Fields
        private const decimal taxa = 0.10m;
        #endregion

        #region Proprieties
        public override string Id
        {
            get
            {
                return Titular + "(CC)";
            }
        }
        #endregion

        #region Constructor
        public ContaCorrente(string t) : base(t) { }
        #endregion

        #region Methods
        public override void Sacar(decimal val)
        {
            decimal desconto = val * taxa;
            base.Sacar(val);
            base.Sacar(desconto);
        }
        #endregion
    }
}
