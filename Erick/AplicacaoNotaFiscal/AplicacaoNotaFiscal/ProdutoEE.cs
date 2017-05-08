using System;

namespace AplicacaoNotaFiscal
{
    public class ProdutoEE : Produto
    {
        #region Fields
        private int garantia;
        #endregion

        #region Properties
        public int Garantia { get { return garantia; } }
        #endregion

        #region Constructor
        public ProdutoEE(int c, string d, double p) : base(c, d, p)
        {
            garantia = 6;
        }
        #endregion

        #region Methods
        public string GerarGarantia()
        {
            return string.Format("Produto {0} com {1} mêses de garantia", Desc, garantia);
        }
        #endregion
    }
}
