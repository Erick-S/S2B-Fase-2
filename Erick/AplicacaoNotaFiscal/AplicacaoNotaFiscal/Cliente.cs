using System;

namespace AplicacaoNotaFiscal
{
    public class Cliente : IComparable<Cliente>
    {
        #region Fields
        private int codigo;
        private string nome;
        #endregion

        #region Properties
        public int Cod { get { return codigo; } }

        public string Nome { get { return nome; } }
        #endregion

        #region Constructor
        public Cliente(int c, string n)
        {
            codigo = c;
            nome = n;
        }
        #endregion

        #region Methods
        public int CompareTo(Cliente cli)
        {
            return nome.CompareTo(cli.nome);
        }
        #endregion
    }
}
