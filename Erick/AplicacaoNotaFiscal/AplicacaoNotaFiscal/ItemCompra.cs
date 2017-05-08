using System;

namespace AplicacaoNotaFiscal
{
    public class ItemCompra : IComparable<ItemCompra>
    {
        #region Fields
        private int quantidade;
        private Produto produto;
        #endregion

        #region Properties
        public int Quantidade { get { return quantidade; } }

        public Produto Produto { get { return produto; } }

        public double Valor
        {
            get
            {
                return quantidade * produto.PrecoUnitario;
            }
        }
        #endregion

        #region Constructor
        public ItemCompra(int qtd, Produto p)
        {
            quantidade = qtd;
            produto = p;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("{0} {1, -20} \t {2} {3:c}\n", produto.Cod, produto.Desc, quantidade, Valor);
        }

        public int CompareTo(ItemCompra other)
        {
            return Valor.CompareTo(other.Valor);
        }
        #endregion
    }
}
