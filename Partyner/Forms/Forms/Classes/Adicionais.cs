using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Adicionais
    {

        private string id_Adicionais;

        public string Id_Adicionais
        {
            get { return id_Adicionais; }
            set { id_Adicionais = value; }
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

        public Adicionais(string nome, double preco,string id ) 
        {
            this.nome = nome;
            this.preco = preco;
            this.id_Adicionais = id;
        }

        public Adicionais(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
    }
}
