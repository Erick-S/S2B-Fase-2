using System;

namespace Laboratorio4
{
    class ContaCorrente
    {
        #region Fields
        private decimal saldo;
        private int numeroOperacoes;
        //private decimal saldoAcumulado;
        public decimal mediaSaldo { get
            {
                if (numeroOperacoes > 0)
                {
                    return saldo / numeroOperacoes;
                }
                else
                {
                    return 0;
                }
            }
        }
        #endregion

        #region Proprieties
        public decimal Saldo { get { return saldo; } }
        public string Nome { get; private set; }
        public DateTime DataCriacao { get; private set; }
        #endregion

        #region Constructor
        public ContaCorrente(string nome)
        {
            Nome = nome;
            DataCriacao = DateTime.Now;
            saldo = 0;
            numeroOperacoes = 0;
            //saldoAcumulado = 0;
        }
        public ContaCorrente (string nome, decimal val) : this(nome)
        {
            Depositar(val);
        }
        #endregion

        #region Methods
        public void Depositar (decimal val)
        {
            saldo += val;
            AcumulaSaldo();
        }

        public void Sacar (decimal val)
        {
            saldo -= val;
            AcumulaSaldo();
        }

        private void AcumulaSaldo()
        {
            //saldoAcumulado += saldo;
            numeroOperacoes++;
        }
        #endregion
    }
}
