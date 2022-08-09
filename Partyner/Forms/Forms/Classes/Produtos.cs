using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Produtos
    {
        private string idProdutos;

        public string IdProdutos
        {
            get { return idProdutos; }
            set { idProdutos = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private double preco;

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }


        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
       
        public Produtos(string nome, string categoria, double Preco) 
        {
            this.nome = nome;
            this.preco = Preco;
            this.categoria = categoria;
        }

        public Produtos(string nome, string categoria, double Preco, string idProduto)
        {
            this.nome = nome;
            this.preco = Preco;
            this.categoria = categoria;
            this.idProdutos = idProduto;
        }
    }
}
