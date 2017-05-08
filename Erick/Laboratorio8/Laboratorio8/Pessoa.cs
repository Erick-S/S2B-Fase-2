using System;

namespace Laboratorio8
{
    class Pessoa : IComparable<Pessoa>
    {
        #region Fields
        private string nome;
        private int idade;
        #endregion

        #region Properties
        public string Nome { get { return nome; } }
        public int Idade { get; set; }
        #endregion

        #region Constructor
        public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
        }
        #endregion

        #region Methods
        public int CompareTo(Pessoa other)
        {
            return idade.CompareTo(other.idade);
        }
        #endregion
    }
}
