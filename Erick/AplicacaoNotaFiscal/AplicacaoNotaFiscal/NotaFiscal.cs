using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacaoNotaFiscal
{
    public class NotaFiscal
    {
        #region Fields
        private Cliente cliente;
        private DateTime dataCompra;
        private List<ItemCompra> items;
        #endregion

        #region Properties
        public Cliente Cliente { get { return cliente; } }
        public DateTime DataCompra { get { return dataCompra; } }
        #endregion

        #region Constructor
        public NotaFiscal(Cliente c)
        {
            cliente = c;
            dataCompra = DateTime.Now;
            items = new List<ItemCompra>();
        }
        #endregion

        #region Methods
        public void NotaCompra(Cliente c)
        {
            throw new NotImplementedException();
        }

        public void Add(int qtd, Produto p)
        {
            items.Add(new ItemCompra(qtd, p));
        }

        public string GerarNota()
        {
            StringBuilder notaString = new StringBuilder("Boas compras! ");
            notaString.AppendLine("Cliente: " + cliente.Nome);
            notaString.AppendLine("Data da compra " + dataCompra.ToLongDateString());
            notaString.AppendLine("Cod / Desc \t\t\t Qtd / Valor");
            double valorTotal = 0.0;
            items.Sort();
            foreach (ItemCompra item in items)
            {
                notaString.Append(item.ToString());
                valorTotal += item.Valor;
            }
            notaString.AppendLine("Valor total: R$" + valorTotal);
            foreach (ItemCompra iEE in items)
            {
                if (iEE.Produto is ProdutoEE)
                {
                    var iee = iEE.Produto as ProdutoEE;
                    notaString.AppendLine(iee.GerarGarantia());
                }
            }
            return notaString.ToString();
        }
        #endregion
    }
}
