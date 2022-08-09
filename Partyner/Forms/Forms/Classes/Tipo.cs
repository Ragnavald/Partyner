using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Tipo
    {

        private string id_tipo;

        public string Id_tipo
        {
            get { return id_tipo; }
            set { id_tipo = value; }
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

        public Tipo(string nome, double preco) 
        {
            this.nome = nome;
            this.preco = preco;
        }

        public Tipo(string nome, double preco, string id_tipo)
        {
            this.nome = nome;
            this.preco = preco;
            this.id_tipo = id_tipo;
        }

    }
}
