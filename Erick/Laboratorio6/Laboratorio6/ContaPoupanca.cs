using System;

namespace Laboratorio6
{
    class ContaPoupanca : Conta
    {
        #region Proprieties
        public decimal TaxaJuros { get; set; }
        public DateTime DataAniversario { get; private set; }
        public override string Id
        {
            get
            {
                return Titular + "(CP)";
            }
        }
        #endregion

        #region Constructor
        public ContaPoupanca(decimal j, DateTime d, string t) : base(t)
        {
            TaxaJuros = j;
            DataAniversario = d;
        }
        #endregion

        #region Methods
        public void AdicionarRendimento()
        {
            DateTime hoje = DateTime.Now;
            if(hoje.Day == DataAniversario.Day && hoje.Month == DataAniversario.Month)
            {
                decimal rendimento = Saldo * TaxaJuros;
                Depositar(rendimento);
            }
        }
        #endregion
    }
}
