using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Cliente
    {
        private string idCliente;

        public string IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        private string idEvento;

        public string IdEvento
        {
            get { return idEvento; }
            set { idEvento = value; }
        }

        private string cpf;

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Cliente(string nome, string CPF ) 
        {
            this.nome = nome;
            this.cpf = CPF;
        }

        public Cliente(string nome, string CPF,string idCliente)
        {
            this.nome = nome;
            this.cpf = CPF;
            this.idCliente = idCliente;
        }

        public Cliente(string idCliente) 
        {
            this.idCliente = idCliente;
        }
    }
}
