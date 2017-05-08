using System;

namespace AplicacaoNotaFiscal
{
    public class Produto : IComparable<Produto>
    {
        #region Fields
        private int codigo;
        private string descricao;
        private double precoUnitario;
        #endregion

        #region Properties
        public int Cod { get { return codigo; } }

        public string Desc { get { return descricao; } }

        public double PrecoUnitario { get { return precoUnitario; } }
        #endregion

        #region Constructor
        public Produto(int c, string d, double p)
        {
            codigo = c;
            descricao = d;
            precoUnitario = p;
        }
        #endregion

        #region Methods
        public int CompareTo(Produto prod)
        {
            return descricao.CompareTo(prod.descricao);
        }
        #endregion
    }
}
