using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Funcionario
    {
        private string id_Funcionario;

        public string Id_Funcionario
        {
            get { return id_Funcionario; }
            set { id_Funcionario = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public Funcionario(string nome, string telefone, string cpf, string rg, string endereco, string id) 
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            this.rg = rg;
            this.endereco = endereco;
            this.id_Funcionario = id;
        }

        public Funcionario(string nome, string telefone, string cpf, string rg, string endereco)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            this.rg = rg;
            this.endereco = endereco;
        }

        public Funcionario(string idFunc) 
        {
            this.id_Funcionario = idFunc;
        }
    }
}
